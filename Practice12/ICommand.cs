using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public interface ICommand
    {
         void AddStudent();
        void AddStudent(int v);
    }
}
