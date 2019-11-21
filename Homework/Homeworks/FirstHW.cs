using System;

namespace Homework.Homeworks
{
    class FirstHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            string input = args[0];
            string result = "";
            foreach(char value in input)
            {
                if(result.IndexOf(value) == -1) {
                    result += value;
                }
            }

            Console.WriteLine("Input line: {0},\r\nOutput line: {1}", input, result);
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
