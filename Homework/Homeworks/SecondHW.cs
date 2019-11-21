using System;
using System.Collections.Generic;

namespace Homework.Homeworks
{
    class SecondHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            string[] input = args[0].Split(',');
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach(string value in input)
            {
                int intValue = 0;
                try {
                    intValue = int.Parse(value);
                }
                catch(Exception e) 
                {
                    Console.WriteLine("'{0}' - {1}", value, e.Message);
                    continue;
                }

                if(dictionary.ContainsKey(intValue)) {
                    dictionary[intValue]++;
                }
                else {
                    dictionary[intValue] = 1;
                }
            }

            bool noValueMatch = true;
            foreach(KeyValuePair<int, int> numbers in dictionary)
            {
                if((double)numbers.Value >= (double)input.Length / 2) 
                {
                    Console.WriteLine("Number = {0}, frequency = {1:0.00}%", numbers.Key, ((double)numbers.Value / (double)input.Length) * 100);
                    noValueMatch = false;
                }
            }

            if(noValueMatch) {
                Console.WriteLine("No value had more than 50% in input list.");
            }
        }

        private bool ShowHelp(string[] args)
        {
            if(args.Length == 0 || Array.IndexOf(args, "/?") >= 0)
            {
                Console.WriteLine("Params: array of numbers separated by comma - no spaces between them");
                return true;
            }
            return false;
        }
    }
}
