using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MyQueue
    {
        public MyNode Head { get; set; }                            // голова 
        public MyNode Tail { get; set; }
        public int Count { get; set; }                       // число элементов
        public MyQueue()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool QueueIsEmpty()              // проверка на пустоту
        {
            return Head == null;
        }

        public void InQueue(double inf)            // положить в хвост очереди
        {
            MyNode p = new MyNode(inf, null); //{ Inf = inf, Next = null };
            if (QueueIsEmpty())
            {
                Head = p;
                Tail = p;
            }
            else
            {
                Tail.Next = p;
                Tail = p;
            }
            Count++;
        }

        public double OutQueue()                   // взять из головы очереди
        {
            MyNode p = Head;
            Head = Head.Next;
            Count--;
            return p.Inf;
        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            MyNode p = Head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.Inf.ToString();
                p = p.Next;
            }
            return st;
        }

        private bool Ybyv()
        {
            MyNode p = Head;
            while (p.Next != null)
            {
                if (p.Inf <= p.Next.Inf)
                    return false;
                p = p.Next;
            }
            return true;
        }

        private bool Vozr()
        {
            MyNode p = Head;
            while (p.Next != null)
            {
                if (p.Inf >= p.Next.Inf)
                    return false;
                p = p.Next;
            }
            return true;
        }

        public int VozrOrYbuv()
        {
            if (Vozr())
                return 1;
            else if (Ybyv())
                return -1;
            else return 0;
        }

    }
}
