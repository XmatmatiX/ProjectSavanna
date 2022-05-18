using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model
{
    public abstract class Carnivorous : Animal
    {
        public int Stamina { get; set; }

        public Carnivorous() : base()
        {
            IsHerbivores = false;

            Stamina = 8;
        }

        public override void Eat(int HPRestore)
        {
            if (IsHunted())
            {
                HP += 75;
            }
        }

        public override void Move()
        {
            if (IsHuntTime)
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
    }
}
