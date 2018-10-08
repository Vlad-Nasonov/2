using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ConvertUtils
    {
        public static MyList StrToMyList(string str)
        {
            MyList list = new MyList();
            string[] arr = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = arr.Length-1; i >=0; i--)
            {
                list.Add(Convert.ToDouble(arr[i]));
            }
            return list;
        }

        public static string MyListToStr(MyList list)
        {
            string s;
            s = Convert.ToString(list.Head.Inf);
            MyNode n= list.Head.Next;
            while (n != null) 
            {
                s += "\r\n" + Convert.ToString(n.Inf);
                n = n.Next;
            }
            return s;
        }

        public static MyQueue StringToMyQueue(string s)
        {
            MyQueue queue = new MyQueue();
            string[] arr = s.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mass = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                queue.InQueue(Convert.ToDouble(arr[i]));
            }
            return queue;
        }

        public static string MyQueueToString(MyQueue q)
        {
            string s = Convert.ToString(q.OutQueue());
            while (!q.QueueIsEmpty())
            {
                s += "\r\n" + Convert.ToString(q.OutQueue());
            }
            return s;
        }
    }
}
