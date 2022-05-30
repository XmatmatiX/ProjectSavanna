using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Acacia : Tree
    {
        public Acacia() : base()
        {
            Name = "Acacia";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Acacia.png"));
            HPRestore = 25;
            PlantTime = 7;
            ActualPlantTime = PlantTime;
        }
    }
}
