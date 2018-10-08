using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MyList
    {
        public MyNode Head { get; set; }                     // голова списка
        public int Count  {get;set;}                     // число элементов

        public MyList()                         // Конструктор
        {
            Head = null;
            Count = 0;
        }

        public void Add(double inf)                // Add
        {
            MyNode p = new MyNode(inf, Head);
            Head = p;
            Count++;
        }

        public void Clear()
        {
            MyNode p = Head;
            Head = null;
            //while (p != null)
            //{
            //    MyNode q = p;
            //    p = p.next;
            //    q.next = null;
            //    //q.Dispose();
            //}
        }



        public void GetList()
        {
            int numberOfNegative = FindNegativeNumber();
            MyNode p = Head;
            if (p != null)
                do
                {
                    if (p.Inf < 0)
                        numberOfNegative--;
                    p.Inf = numberOfNegative;
                    p = p.Next;
                }
                while (p != null);
        }

        private int FindNegativeNumber()
        {
            int n = 0;
            MyNode p = Head;
            if (p != null)
                do
                {
                    if (p.Inf < 0)
                        n++;
                    p = p.Next;
                }
                while (p != null);
            return n;
        }
    }
}
