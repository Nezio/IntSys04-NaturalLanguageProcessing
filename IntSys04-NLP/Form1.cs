using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            //lblStatus.Text = "Working...";
            
            // debug paths
            encodedPath = "D://Workbench//encoded.txt";
            probPath = "D://Workbench//prob.txt";
            outputPath = "D://Workbench//output.txt";

            // allowed characters
            string[] characters = { "A" , "B" , "V" , "G" , "D" , "Đ" , "E" , "Ž" , "Z" , "I" , "J" , "K" , "L" , "M" , "N" , "O" , "P" , "R" , "S" , "T" , "Ć" , "U" , "F" , "H" , "C" , "Č" , "Š" , "a" , "b" , "v" , "g" , "d" , "đ" , "e" , "ž" , "z" , "i" , "j" , "k" , "l" , "m" , "n" , "o" , "p" , "r" , "s" , "t" , "ć" , "u" , "f" , "h" , "c" , "č" , "š"};
            
            // initialize encoded probabilities list with -1 as probability
            var encodedTextProb = new List<KeyValuePair<string, float>>();
            foreach(string s in characters)
            {
                encodedTextProb.Add(new KeyValuePair<string, float>(s, -1f));
            }

            // initialize decoded probabilities  list with -1 as probability
            var normalTextProb = new List<KeyValuePair<string, float>>();
            foreach (string s in characters)
            {
                normalTextProb.Add(new KeyValuePair<string, float>(s, -1f));
            }

            // access list like this
            Console.WriteLine(encodedTextProb.First(kvp => kvp.Key == "a").Value);


            // load normal text prob

            // open txt file
            // go trough each char
            // if it is in characters[] (skip special chars and numbers)
                // increment its value in listProb
            // normalize values to 0 to 1
            // maybe order list by value?

            // go trough encoded .txt chars
            // if it is in the list
                // compare prob. and replace (dont replace if prob. is -1)
                // append to new decoded .txt file
            // else (special characters)
                // just copy char to new .txt

        }
    }
}
