using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Cat : Pet, ITalkable
    {
        private int MouseKilled;

        public Cat(int mouseKills, String name)
        {
            this.MouseKilled = mouseKills;
            this.Name = name;
        }
        public override String talk()
        {
            return "Meow";
        }

    }
}
