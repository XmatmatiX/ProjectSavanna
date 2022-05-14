using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Animal
    {
        private static int staticID { get; set; }
        public int ID { get; set; }
        public int HP { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int Sight { get; set; }
        public bool WalkOnWater { get; set; }
        public bool IsHerbivores { get; set; }

        public Animal()
        {
            ID = staticID;
            staticID++;
            WalkOnWater = false;
        }
    }
}
