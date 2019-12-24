using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class Auditoriyas : Command
    {
        //public int Counter { get; private set; }

        //protected Auditorii auditorii;
        public Auditorii auditoriya;
        public int counteraudit = 0;
        public Auditoriyas(Auditorii auditoriya)
        {
            this.auditoriya = auditoriya;
        }

        public Auditoriyas(int v)
        {
        }

        public int AddStudent(int tmp) 
        {
                counteraudit++;
               Console.WriteLine($"Free count student {tmp-1-counteraudit}");
            return tmp++;
        }
        protected override void InternalLogic()
        {
            Console.WriteLine("+++++++++++++++++++++++++++");
        }
    }
}
