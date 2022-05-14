using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Carnivorous : Animal
    {
        public int Atack { get; set; }
        public bool AtackCarnivorous { get; set; }
        public int VictimID { get; set; }
        public int VictimPositionX { get; set; }
        public int VictimPositionY { get; set; }

        public Carnivorous() : base()
        {
            AtackCarnivorous = false;
            IsHerbivores = false;
        }
    }
}
