using System;

namespace Homework
{
    class Program
    {
        //used for homework file name validation
        private static string[] validTargets =
        {
            "FirstHW", "SecondHW", "ThirdHW", "FourthHW", "FifthHW", "SixthHW"
        };

        static void Main(string[] args)
        {
            string exeName = Program.GetExecutableName();
            if(Array.IndexOf(validTargets, exeName) < 0) //no valid homework found in filename
            {
                if(args.Length == 0 || Array.IndexOf(validTargets, args[0]) < 0) //also no valid homework found in arguments
                {
                    Program.ShowHelp();
                    goto end;
                }
                else
                {
                    exeName = args[0]; //homework name in firs params
                    args = Utils.Utilities.slice(args, 1, null); //rest of params for homework
                }
            }

            //create the homework instance using reflection...
            Interface.HomeworkHandler handler = (Activator.CreateInstance(Type.GetType("Homework.Homeworks." + exeName)) as Interface.HomeworkHandler);
            handler.Handle(args);

        end:
            Console.ReadKey();
        }

        static private string GetExecutableName()
        {
            //on windows we can't get the real file name using the 'Environment.CommandLine'
            //also on windows you will not get the real soft link name...
            string exeName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            if(exeName.Contains("mono")) //on linux this string contain the mono executable name so use the cmd line
            {
                exeName = System.IO.Path.GetFileName(Environment.CommandLine);
            }

            if(exeName.Contains(".exe")) { //for win
                return exeName.Substring(0, exeName.IndexOf(".exe"));
            }
            else if(exeName.Contains(".dll")) { //for linux
                return exeName.Substring(0, exeName.IndexOf(".dll"));
            }
            else { //fallback
                return exeName;
            }
        }

        static private void ShowHelp()
        {
            Console.WriteLine("Use one of the following executables " + string.Join(", ", Program.validTargets) + " or you can pass the homework name as first argument to this executable.");
        }
    }

}
