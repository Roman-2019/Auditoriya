using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice12
{
    public class Auditorii
    {


        private int counter;
        public int Counter
        {
            set
            {
                //Auditorii.Counter = value;
                counter = value;
            }
            get
            {
                return counter;
            }
            
        }

        public Auditorii()
        {
            Auditoriya = new List<Auditorii>();
        }
        List<Auditorii> Auditoriya;

        public int AddCounteri(int z) 
        {

            return z;
        }
    }
}
