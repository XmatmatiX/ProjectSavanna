using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Aloe : Herb
    {
        public Aloe() : base()
        {
            Name = "Aloe";
            HPRestore = 10;
            PlantTime = 4;
            ActualPlantTime = PlantTime;
        }
    }
}
