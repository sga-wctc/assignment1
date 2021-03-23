using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    abstract class Pet
    {
        protected String Name;

        public Pet()
        {
        }

        public String getName()
        {
            return Name;
        }

        public virtual String talk()
        {
            return "";
        }
    }
}
