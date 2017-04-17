using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7kyu_ExesandOhs
{
    public static class Kata
    {
        public static void Main(string[] args)
        {

        }

        public static bool XO(string input)
        {
            char[] chars = input.ToLower().ToCharArray();
            int x = 0;
            int o = 0;
            foreach (char c in chars)
            {
                if (c == 'o') o++;
                if (c == 'x') x++;
            }

            if (x == o) return true;
            else return false;

        }
    }


}
