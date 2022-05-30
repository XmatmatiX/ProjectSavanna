using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Baobab : Tree
    {
        public Baobab() : base()
        {
            Name = "Baobab";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Baobab.png"));
            HPRestore = 45;
            PlantTime = 12;
            ActualPlantTime = PlantTime;
        }
    }
}
