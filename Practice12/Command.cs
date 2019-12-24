using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class Command : ICommand
    {
        public void AddStudent()
        {
            InternalLogic();
        }
        public void AddStudent(int v)
        {
            Auditoriyas auditoriyas = new Auditoriyas(v);
            auditoriyas.AddStudent(v);
        }
        protected virtual void InternalLogic()
        {
            Console.WriteLine("======================");
        }
    }
}
