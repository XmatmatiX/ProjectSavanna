using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Giraffe : Herbivores
    {
        public Giraffe() : base()
        {
            Name = "Giraffe";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Giraffe.jpg"));
            Sight = 5;
            HP = 50;

            EatTrees = true;
            EatHerbs = false;
        }
    }
}
