using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ProjectSavanna.Model
{
    public class Lion : Carnivorous
    {

        public Lion() : base()
        {
            Name = "Lion";
            ModelImage = new BitmapImage(new Uri(@"pack://application:,,,/Image/Lion.jpg"));
            Sight = 4;
            HP = 50;

        }
    }
}
