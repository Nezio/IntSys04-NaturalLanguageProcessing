using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSys04_NLP
{
    class CharProbPair
    {
        public string character;
        public float probability;

        public CharProbPair(string character, float probability)
        {
            this.character = character;
            this.probability = probability;

        }
    }
}
