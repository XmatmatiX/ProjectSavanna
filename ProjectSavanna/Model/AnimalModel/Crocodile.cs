using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public class Crocodile : Carnivorous
    {
        public int IsVisible { get; set; }
        public Crocodile() : base()
        {
            Sight = 4;
            HP = 50;
            WalkOnWater = true;
            AtackCarnivorous = true;

        }
    }
}
