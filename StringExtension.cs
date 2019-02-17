using System;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static void OrderStringsByLength(string[] array)
        {
            if(array == null)
                throw new ArgumentNullException("Agrument cannot be null");
           Array.Sort(array, Comparison);
        }

        private static int Comparison(string x, string y)
        {
            if(x == null || y == null)
                throw new ArgumentNullException("Agrument cannot be null");
            if (x.Length > y.Length)
                return 1;
            if (x.Length == y.Length)
                return 0;

            return -1;

        }
    }
}
