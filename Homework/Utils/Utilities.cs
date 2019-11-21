using System;

namespace Homework.Utils
{
    class Utilities
    {
        public static string[] slice(string[] array, int from, int? to)
        {
            //cant use range because mono will trow an error :(
            //return array[from..to];

            if(array.Length == from) {
                return new string[0];
            }

            string[] result = new string[array.Length - from];
            int realTo = to == null ? array.Length - from : (int)to;
            Array.Copy(array, from, result, 0, realTo);

            return result;
        }
    }
}
