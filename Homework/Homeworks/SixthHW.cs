using System;

namespace Homework.Homeworks
{
    class SixthHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            if(args.Length == 1) { //maybe a quoted string as param
                args = args[0].Trim('"').Split(' ');
            }

            Console.WriteLine("Length of the last word is {0}", args.Length > 0 ? args[args.Length - 1].Length : 0);
        }

        private bool ShowHelp(string[] args)
        {
            if(Array.IndexOf(args, "/?") >= 0)
            {
                Console.WriteLine("Params: word1? word2? word3? ...");
                return true;
            }
            return false;
        }
    }
}
