using ProjectSavanna.Model.PlantsModel;
using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ProjectSavanna.Test
{
    public class PlantTest
    {
        Plant plant = new Aloe();

        [Fact]
        public void GetSetPosition()
        {
            plant.SetPosition();

            int[] position = plant.GetPosition();

            Assert.True(position.Length == 2);
            Assert.True(position[0] >= 0 && position[0] < 50);
            Assert.True(position[1] >= 0 && position[1] < 50);
        }

        [Fact]
        public void SetNewPosition()
        {
            int[] pos1 = plant.GetPosition();
            plant.SetPosition(pos1, 10);
            int[] pos2 = plant.GetPosition();

            Assert.False(pos1[0] == pos2[0] && pos1[1] == pos2[1]);
            Assert.True(pos2[0] >= 0 && pos2[0] < 50);
            Assert.True(pos2[1] >= 0 && pos2[1] < 50);
        }
    }
}
