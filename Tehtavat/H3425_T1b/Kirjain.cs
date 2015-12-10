using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3425_T1b
{
    public class Kirjain
    {
        public char kirjain { get; set; }
        public int value { get; set; }

        public Kirjain(char c)
        {
            this.kirjain = c;
            this.value = 1;
        }
    }
}
