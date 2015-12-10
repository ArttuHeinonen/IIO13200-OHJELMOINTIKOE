using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3425_T1b
{
    public class BLKirjain
    {
        List<Kirjain> kirjaimet = new List<Kirjain>();
        public int totalChars, differentChars;

        public BLKirjain()
        {
            totalChars = 0;
            differentChars = 0;
        }

        public void AddCharacter(char c)
        {
            if (!IsIllegalCharacter(c))
            {
                if (IsNewCharacter(c))
                {
                    kirjaimet.Add(new Kirjain(c));
                    totalChars++;
                    differentChars++;
                }
                else
                {
                    foreach (Kirjain k in kirjaimet)
                    {
                        if (c == k.kirjain)
                        {
                            k.value++;
                            totalChars++;
                        }
                    }
                }
            }
        }

        public Boolean IsNewCharacter(char c)
        {
            foreach (Kirjain k in kirjaimet)
            {
                if(c == k.kirjain)
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean IsIllegalCharacter(char c)
        {
            if(c == ' ' || c == '.' || c == '-' || c == '_' || c == ';' || c == ':' || c == '*' || c == '<' || c == '>' || c == '(' || c == ')' || c == '=' || c == '+')
            {
                return true;
            }
            return false;
        }

        public void ClearList()
        {
            kirjaimet.Clear();
            totalChars = 0;
            differentChars = 0;
        }

        public List<Kirjain> GetKirjaimet()
        {
            return this.kirjaimet;
        }
    }
}
