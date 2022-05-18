using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public class Lion : Carnivorous
    {

        public Lion() : base()
        {
            Name = "Lion";
            Sight = 4;
            HP = 50;

        }
    }
}
