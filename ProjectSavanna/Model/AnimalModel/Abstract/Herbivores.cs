using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Herbivores : Animal
    {
        public bool EatTrees { get; set; }
        public bool EatHerbs { get; set; }

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
