using System;
using System.Collections.Generic;

namespace Homework.Homeworks
{
    class ThirdHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            string input = args[0];
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            foreach(char value in input)
            {
                if(dictionary.ContainsKey(value)) {
                    dictionary[value]++;
                }
                else {
                    dictionary[value] = 1;
                }
            }

            Console.WriteLine("Frequency of chars:");
            foreach (KeyValuePair<char, int> chars in dictionary) {
                 Console.WriteLine("char = {0}, frequency = {1}", chars.Key, chars.Value);
            }
        }

        private bool ShowHelp(string[] args)
        {
            if(args.Length == 0 || Array.IndexOf(args, "/?") >= 0)
            {
                Console.WriteLine("Params: string");
                return true;
            }
            return false;
        }
    }
}
