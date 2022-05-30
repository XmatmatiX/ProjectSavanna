using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Zebra : Herbivores
    {
        public Zebra() : base()
        {
            Name = "Zebra";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Zebra.jpg"));
            Sight = 4;
            HP = 30;
        }
    }
}
