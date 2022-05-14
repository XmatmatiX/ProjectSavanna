using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel.Abstract
{
    public abstract class Tree : Plant
    {
        public Tree() : base()
        {
            IsTree = true;
            PlantRange = 5;
        }
    }
}
