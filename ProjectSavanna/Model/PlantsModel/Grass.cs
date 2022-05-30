using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Grass : Herb
    {
        public Grass() : base()
        {
            Name = "Grass";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Grass.png"));
            HPRestore = 5;
            PlantTime = 2;
            ActualPlantTime = PlantTime;
        }
    }
}
