using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel
{
    public class Baobab : Tree
    {
        public Baobab() : base()
        {
            Name = "Baobab";
            HPRestore = 45;
            PlantTime = 12;
            ActualPlantTime = PlantTime;
        }
    }
}
