using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Bird: Pet, ITalkable
    {
        private Boolean Flies;

        public Bird(Boolean flies, String name)
        {
            this.Flies = flies;
            this.Name = name;
        }

        public override String talk()
        {
            return "Tweet Tweet";
        }

    }
}
