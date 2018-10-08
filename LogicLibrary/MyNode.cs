using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MyNode
    {
        public double Inf { get; set; }
        public MyNode Next { get; set; }

        public MyNode(double inf, MyNode next)    // Конструктор
        {
            this.Inf = inf;
            this.Next = next;
        }
    }
}
