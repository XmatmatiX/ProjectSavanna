using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public class Giraffe : Herbivores
    {
        public Giraffe() : base()
        {
            Name = "Giraffe";
            Sight = 5;
            HP = 50;

            EatTrees = true;
            EatHerbs = false;
        }
    }
}
