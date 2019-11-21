using System;
using System.Collections.Generic;

namespace Homework.Homeworks
{
    class FourthHW : Interface.HomeworkHandler
    {
        public void Handle(string[] args)
        {
            if(this.ShowHelp(args)) {
                return;
            }

            LinkedList<string> list = new LinkedList<string>(args);
            LinkedListNode<string> pivot = list.First;
            for (int i = 0; i < list.Count - 1; i++)
            {
                LinkedListNode<string> node = pivot.Next;
                list.Remove(node);
                list.AddFirst(node);
            }

            Console.WriteLine("Reversed list: " + string.Join(" ", list));

            pivot = list.First;
            this.ReverseList(ref list, ref pivot);
            Console.WriteLine("Reversed list: " + string.Join(" ", list));

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

        private void ReverseList(ref LinkedList<string> list, ref LinkedListNode<string> pivot)
        {
            if(pivot.Next == null) {
                return;
            }

            LinkedListNode<string> node = pivot.Next;
            list.Remove(node);
            list.AddFirst(node);

            this.ReverseList(ref list, ref pivot);
        }
    }
}
