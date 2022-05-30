using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Herbivores : Animal
    {

        public Herbivores() : base()
        {
            EatHerbs = true;
            EatTrees = false;
            IsHerbivores = true;
        }

        public override void Eat(int HPRestore)
        {
            HP += HPRestore;
        }
        public override void Move()
        {
            if (IsHuntTime)
            {
                if (HuntPositionX > PositionX)
                {
                    PositionX--;
                }
                else if (HuntPositionX < PositionX)
                {
                    PositionX++;
                }

                if (HuntPositionY > PositionY)
                {
                    PositionY--;
                }
                else if (HuntPositionY < PositionY)
                {
                    PositionY++;
                }
                if (PositionX > 49)
                {
                    PositionX = 49;
                }
                else if (PositionX < 0)
                {
                    PositionX = 0;
                }
                if (PositionY > 49)
                {
                    PositionY = 49;
                }
                else if (PositionY < 0)
                {
                    PositionY = 0;
                }
            }
            else
            {
                base.Move();
            }
        }
        public override void StartHunt(int x, int y)
        {
            if (!IsHuntTime)
            {
                Random random = new Random();
                if (random.Next(0, 6) >= 1)
                {
                    IsHuntTime = true;
                    HuntPositionX = x;
                    HuntPositionY = y;
                }
            }
        }
    }
}
