using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Antelope : Herbivores
    {
        public Antelope() : base()
        {
            Name = "Antelope";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Antelope.jpg"));
            Sight = 3;
            HP = 25;
        }


    }
}
