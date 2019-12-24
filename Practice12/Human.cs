using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
     public class Human
    {
        //public int Student { get; set; }
        
        private int teacher;
        public int Teacher 
        {
            get
            {
                return teacher;
            }
            set 
            {
                teacher = 1;
            }
        }

        public  void Student(int coun) 
        {
            Coun = coun;
        }
        public int Coun { get; set; }

        public override string ToString()
        {
            return $"Counter {Coun}";
        }


        public void StudentsAdd() 
        {
            //Student.coun++;
            Coun++;
            
        }
    }
}
