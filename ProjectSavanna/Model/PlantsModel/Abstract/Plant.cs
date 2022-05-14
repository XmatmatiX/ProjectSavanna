﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSavanna.Model.PlantsModel.Abstract
{
    public abstract class Plant
    {
        private static int staticID { get; set; }
        public int ID { get; set; }
        public int HPRestore { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public bool IsTree { get; set; }
        public int PlantTime { get; set; }
        public int ActualPlantTime { get; set; }
        public int PlantRange { get; set; }
        public Plant()
        {
            ID = staticID;
            staticID++;
        }
    }
}