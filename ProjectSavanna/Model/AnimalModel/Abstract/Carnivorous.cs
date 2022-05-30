using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Carnivorous : Animal
    {
        private int Stamina { get; set; }

        public Carnivorous() : base()
        {
            IsHerbivores = false;

            Stamina = 8;
        }


        public override void Move()
        {
            if (IsHuntTime && Stamina >=0)
            {
                Stamina--;
                for (int i = 0; i < 2; i++)
                {
                    if (HuntPositionX > PositionX)
                    {
                        PositionX++;
                    }
                    else if (HuntPositionX < PositionX)
                    {
                        PositionX--;
                    }

                    if (HuntPositionY > PositionY)
                    {
                        PositionY++;
                    }
                    else if (HuntPositionY < PositionY)
                    {
                        PositionY--;
                    }
                }
                if (PositionX >49)
                {
                    PositionX = 49;
                }
                else if (PositionX <0)
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
                Stamina++;
                if (Stamina>8)
                {
                    Stamina = 8;
                }
                base.Move();
            }
        }

        public override void StartHunt(int x, int y)
        {
            if (Stamina > 2)
            {
                IsHuntTime = true;
                HuntPositionX = x;
                HuntPositionY = y;
            }
        }
        public override void Eat(int HPRestore)
        {
        }
    }
}
