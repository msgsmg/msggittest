using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventHandlerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.cashEvent += p_cashEvent;
            p.AddCash(550);
        }

        static void p_cashEvent()
        {
            Console.WriteLine("Person gained $100");
        }
    }

    class person
    {
        public delegate void MyEventHandler();
        public event MyEventHandler cashEvent;
        private int _cash;


        public int Cash
        {
            get { return _cash; }
            set 
            { 
                _cash = value;
                // Notify subscribers when cash reaches above 100
                if (_cash > 100)
                {
                    cashEvent();
                }
                
            }
        }

        public void AddCash(int x)
        {
            Cash += x;
        }
    }
}
