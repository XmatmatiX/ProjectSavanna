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
        //public bool WalkOnWater { get; set; }
        public bool IsHerbivores { get; set; }
        public bool IsHuntTime { get; set; }
        public int HuntID { get; set; }
        public int HuntPositionX { get; set; }
        public int HuntPositionY { get; set; }

        public Animal()
        {
            Random random = new Random();
            ID = staticID;
            staticID++;
            PositionX = random.Next(0, 50);
            PositionY = random.Next(0, 50);
        }
        public abstract void StartHunt(int x, int y);
        public abstract void Eat(int HPRestore);
        public virtual void Move()
        {
            Random random = new Random();
            int move = random.Next(1, 9);
            switch (move)
            {
                case 1:
                    PositionX += 1;
                    break;
                case 2:
                    PositionX -= 1;
                    break;
                case 3:
                    PositionY += 1;
                    break;
                case 4:
                    PositionY -= 1;
                    break;
                case 5:
                    PositionY += 1;
                    PositionX += 1;
                    break;
                case 6:
                    PositionY -= 1;
                    PositionX += 1;
                    break;
                case 7:
                    PositionY += 1;
                    PositionX -= 1;
                    break;
                default:
                    PositionY -= 1;
                    PositionX -= 1;
                    break;
            }
        }

        public int[] GetPosition()
        {
            int[] position = { PositionX, PositionY };
            return position;
        }
        public bool IsHunted()
        {
            if (PositionX == HuntPositionX && PositionY == HuntPositionY)
            {
                if (IsHerbivores)
                {
                    HP = 0;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsAlive()
        {
            HP--;
            if (HP > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
