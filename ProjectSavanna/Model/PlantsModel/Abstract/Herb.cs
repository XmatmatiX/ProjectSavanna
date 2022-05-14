using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel.Abstract
{
    public class Herb : Plant
    {
        public Herb() : base()
        {
            IsTree = false;
            PlantRange = 3;
        }
    }
}
