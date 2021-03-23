using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Dog : Pet, ITalkable
    {
        private Boolean Friendly;

        public Dog(Boolean friendly, String name)
        {
            this.Friendly = friendly;
            this.Name = name;
        }

        public override String talk()
        {
            return "Bark";
        }

    }


}
