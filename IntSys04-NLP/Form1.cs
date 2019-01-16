using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntSys04_NLP
{
    public partial class Form1 : Form
    {
        public string encodedPath;
        public string probPath;
        public string outputPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Working...";
            
            // debug paths
            //encodedPath = "D://Workbench//encoded.txt";
            //probPath = "D://Workbench//prob.txt";
            //outputPath = "D://Workbench//output.txt";

            // allowed characters
            string[] characters = { "A" , "B" , "V" , "G" , "D" , "Đ" , "E" , "Ž" , "Z" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "R" , "S" , "T" , "Ć" , "U" , "F" , "H" , "C" , "Č" , "Š" , "a" , "b" , "v" , "g" , "d" , "đ" , "e" , "ž" , "z" , "i" , "j" , "k" , "l" , "m" , "n" , "o" , "p" , "r" , "s" , "t" , "ć" , "u" , "f" , "h" , "c" , "č" , "š"};

            // initialize probability lists
            var normalTextProb = new List<CharProbPair>();
            var encodedTextProb = new List<CharProbPair>();
            foreach (string s in characters)
            {
                normalTextProb.Add(new CharProbPair(s, -1f));
                encodedTextProb.Add(new CharProbPair(s, 0f));
            }

            // load normal text prob
            StreamReader file = new StreamReader(probPath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                normalTextProb.First(kvp => kvp.character == line[0].ToString()).probability = float.Parse(line.Substring(4));
            }
            file.Close();

            // debug 
            //foreach (CharProbPair kvp in normalTextProb)
            //{
            //    Console.WriteLine("Key: " + kvp.character + " Value: " + kvp.probability);
            //}

            // count each char occurence in encoded .txt file
            StreamReader sr = new StreamReader(encodedPath);
            while (sr.Peek() >= 0)
            {
                char chr = (char)sr.Read();

                int pos = Array.IndexOf(characters, chr.ToString());   // does characters string[] contain chr?
                if (pos > -1)
                { // the array contains the string (normal character, not interpunction or space)
                    encodedTextProb.First(kvp => kvp.character == chr.ToString()).probability++;
                }
            }
            sr.Close();

            // normalize values to represent percentage
            float occurenceSum = 0;
            foreach (CharProbPair kvp in encodedTextProb)
            { // get sum of char occurences (right now prob variable holds count, not real prob.)
                occurenceSum += kvp.probability;
            }
            foreach (CharProbPair kvp in encodedTextProb)
            { // normalize
                kvp.probability = kvp.probability / occurenceSum;
            }

            // generate mapping kvp list
            var mapping = new List<CharCharPair>();
            foreach (string s in characters)
            {
                float currentNormalTextProb = normalTextProb.First(kvp => kvp.character == s).probability;
                float currentEncodedTextProb = encodedTextProb.First(kvp => kvp.character == s).probability;
                if (currentNormalTextProb == -1)
                { // char remains the same
                    mapping.Add(new CharCharPair(s, s));
                }
                else
                { // char changes
                    //find nearest percentage
                    string selectedMappingChar = null;
                    float diff = 99;
                    foreach (CharProbPair kvp in normalTextProb)
                    {
                        float newDiff = Math.Abs(currentEncodedTextProb - kvp.probability);
                        if (newDiff < diff)
                        {
                            diff = newDiff;
                            selectedMappingChar = kvp.character;
                        }
                    }
                    // add selected mapping
                    mapping.Add(new CharCharPair(s, selectedMappingChar));
                }
            }

            // debug
            //foreach (CharCharPair kvp in mapping)
            //{
            //    Console.WriteLine("Key: " + kvp.key + " Value: " + kvp.value);
            //}

            // map characters from encoded file and output to new file
            sr = new StreamReader(encodedPath);
            StreamWriter sw = new StreamWriter(outputPath);
            while (sr.Peek() >= 0)
            {
                char chr = (char)sr.Read();
                

                int pos = Array.IndexOf(characters, chr.ToString());   // does characters string[] contain chr?
                if (pos > -1)
                { // the array contains the string (normal character, not interpunction or space)
                    sw.Write(mapping.First(kvp => kvp.key == chr.ToString()).value);
                }
                else
                { // special char or whitespace
                    sw.Write(chr);
                }
            }
            sw.Close();
            sr.Close();

            lblStatus.Text = "Done! Check output file.";
        }

        private void btnEncodedPath_Click(object sender, EventArgs e)
        { // set encoded file path
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt;|All files (*.*)|*.*";
            ofd.ShowDialog();
            encodedPath = ofd.FileName;

            tboxEncodedPath.Text = encodedPath;   // update label
        }

        private void btnProbPath_Click(object sender, EventArgs e)
        { // set prob file path
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt)|*.txt;|All files (*.*)|*.*";
            ofd.ShowDialog();
            probPath = ofd.FileName;

            tboxProbPath.Text = probPath;   // update label

        }

        private void btnOutputPath_Click(object sender, EventArgs e)
        { // set output file path
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file (.txt)|*.txt|All files (*.*)|*.*";
            sfd.ShowDialog();
            outputPath = sfd.FileName;

            tboxOutputPath.Text = outputPath;       // update label
        }
    }
}
