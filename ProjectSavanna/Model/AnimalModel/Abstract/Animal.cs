using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Animal
    {
        public string Name { get; set; }
        protected int HP { get; set; }
        protected int PositionX { get; set; }
        protected int PositionY { get; set; }
        public int Sight { get; set; }
        public bool IsHerbivores { get; set; }
        public bool EatTrees { get; set; }
        public bool EatHerbs { get; set; }
        public bool IsHuntTime { get; set; }
        protected int HuntPositionX { get; set; }
        protected int HuntPositionY { get; set; }

        public Animal()
        {
            SetPosition();
            EatHerbs = false;
            EatTrees = false;
            IsHuntTime = false;
        }
        public void SetPosition()
        {
            Random random = new Random();
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
                    if (PositionX!=49)
                    {
                        PositionX += 1;
                    }
                    break;
                case 2:
                    if (PositionX!=0)
                    {
                        PositionX -= 1;
                    }
                    break;
                case 3:
                    if (PositionY!=49)
                    {
                        PositionY += 1;
                    }
                    break;
                case 4:
                    if (PositionY!=0)
                    {
                        PositionY -= 1;
                    }
                    break;
                case 5:

                    if (PositionY!=49 && PositionX!=49)
                    {
                        PositionY += 1;
                        PositionX += 1;
                    }
                    break;
                case 6:
                    if (PositionY != 0 && PositionX != 49)
                    {
                        PositionY -= 1;
                        PositionX += 1;
                    }
                    break;
                case 7:
                    if (PositionY != 49 && PositionX != 0)
                    {
                        PositionY += 1;
                        PositionX -= 1;
                    }
                    break;
                default:
                    if (PositionY != 0 && PositionX != 0)
                    {
                        PositionY -= 1;
                        PositionX -= 1;
                    }
                    break;
            }
        }

        public int[] GetPosition()
        {
            int[] position = { PositionX, PositionY };
            return position;
        }
        public void IsHunted()
        {
            if (PositionX == HuntPositionX && PositionY == HuntPositionY)
            {
                if (IsHerbivores)
                {
                    HP = 0;
                }
                else
                {
                    HP += 75;
                }
                IsHuntTime = false;
            }
            else
            {
                IsHuntTime = true;
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
        public void SetPosition(int posX, int posY)
        {
            PositionX = posX;
            PositionY = posY;
        }

    }
}
