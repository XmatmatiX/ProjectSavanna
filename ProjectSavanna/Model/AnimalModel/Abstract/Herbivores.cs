using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Herbivores : Animal
    {
        public bool IsEating { get; set; }
        public bool IsRunning { get; set; }

        public bool EatTrees { get; set; }
        public bool EatHerbs { get; set; }
        public int HunterPositionX { get; set; }
        public int HunterPositionY { get; set; }

        public Herbivores() : base()
        {
            EatHerbs = true;
            EatTrees = false;
            IsHerbivores = true;
        }
    }
}
