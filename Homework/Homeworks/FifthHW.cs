using System;
using System.Collections.Generic;

namespace Homework.Homeworks
{
    class FifthHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            LinkedList<string> list = new LinkedList<string>(args);
            LinkedListNode<string> testNode = list.First;

            while(testNode != null)
            {
                LinkedListNode<string> node = null;
                while((node = list.FindLast(testNode.Value)) != testNode)
                {
                    list.Remove(node);
                    node = null;
                }
                testNode = testNode.Next;
            }

            Console.WriteLine("Cleaned list: " + string.Join(" ", list));
        }

        private bool ShowHelp(string[] args)
        {
            if(args.Length == 0 || Array.IndexOf(args, "/?") >= 0)
            {
                Console.WriteLine("Params: word1 word2 word3 ...");
                return true;
            }
            return false;
        }
    }
}
