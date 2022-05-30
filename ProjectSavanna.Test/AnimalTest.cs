using ProjectSavanna.Model;
using System;
using Xunit;

namespace ProjectSavanna.Test
{
    public class AnimalTest
    {
        Animal animal = new Antelope();
        [Fact]
        public void GetSetPosition()
        {
            animal.SetPosition();

            int[] position = animal.GetPosition();

            Assert.True(position.Length == 2);
            Assert.True(position[0] >= 0 && position[0] < 50);
            Assert.True(position[1] >= 0 && position[1] < 50);
        }
        
        [Fact]
        public void Move()
        {
            int[] pos1 = animal.GetPosition();
            animal.Move();
            int[] pos2 = animal.GetPosition();

            Assert.False(pos1[0] == pos2[0] && pos1[1] == pos2[1]);
            Assert.True(pos2[0] >= 0 && pos2[0] < 50);
            Assert.True(pos2[1] >= 0 && pos2[1] < 50);
        }
    }
}
