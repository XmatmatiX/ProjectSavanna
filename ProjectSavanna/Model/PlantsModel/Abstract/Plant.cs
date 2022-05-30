using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ProjectSavanna.Model.PlantsModel.Abstract
{
    public abstract class Plant
    {
        public string Name { get; set; }
        protected ImageSource ModelImage { get; set; }
        public int HPRestore { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool IsTree { get; set; }
        public int PlantTime { get; set; }
        protected int ActualPlantTime { get; set; }
        protected int PlantRange { get; set; }
        public Plant()
        {
            SetPosition();
        }

        public void SetPosition()
        {
            Random random = new Random();
            PositionX = random.Next(0, 50);
            PositionY = random.Next(0, 50);
        }
        public void SetPosition(int[] position, int sight)
        {
            Random random = new Random();
            PositionX = position[0] + random.Next(-sight, sight+1);
            PositionY = position[1] + random.Next(-sight, sight + 1);
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

        public int NewTurn()
        {
            if (ActualPlantTime > 0)
            {
                ActualPlantTime--;
                return 0;
            }
            else
            {
                ActualPlantTime = PlantTime;
                return PlantRange;
            }
        }

        public int[] GetPosition()
        {
            int[] position = { PositionX, PositionY };
            return position;
        }

        public int GetHP()
        {
            return HPRestore;
        }

        public ImageSource GetImageSource()
        {
            return ModelImage;
        }
    }
}
