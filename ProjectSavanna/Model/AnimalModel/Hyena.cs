using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Hyena : Carnivorous
    {
        public Hyena() : base()
        {
            Name = "Hyena";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Hyena.jpg"));
            Sight = 4;
            HP = 35;



        }
    }
}
