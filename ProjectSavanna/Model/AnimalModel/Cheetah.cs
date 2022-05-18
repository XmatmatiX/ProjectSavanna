using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public class Cheetah : Carnivorous
    {

        public Cheetah() : base()
        {
            Name = "Cheetah";
            Sight = 4;
            HP = 75;
        }
    }
}
