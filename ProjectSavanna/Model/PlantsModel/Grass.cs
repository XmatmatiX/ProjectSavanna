using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Grass : Herb
    {
        public Grass() : base()
        {
            HPRestore = 5;
            PlantTime = 2;
            ActualPlantTime = PlantTime;
        }
    }
}
