using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8kyu_InvertValues
{

    public static class ArraysInversion
    {
        public static void Main()
        {

        }

        public static int[] InvertValues(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] *= -1;
            }

            return input;
        }
    }
}
