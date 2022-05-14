using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Acacia : Tree
    {
        public Acacia() : base()
        {
            HPRestore = 25;
            PlantTime = 7;
            ActualPlantTime = PlantTime;
        }
    }
}
