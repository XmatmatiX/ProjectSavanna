using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Cheetah : Carnivorous
    {

        public Cheetah() : base()
        {
            Name = "Cheetah";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Cheetah.jpg"));
            Sight = 4;
            HP = 75;
        }
    }
}
