using ProjectSavanna.Model;
using ProjectSavanna.Model.PlantsModel;
using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectSavanna
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Animal> AnimalList;
        List<Plant> PlantList;
        Image[,] BoardImages;
        bool[,] AnimalPositions;
        bool[,] PlantPositions;
        public MainWindow()
        {
            InitializeComponent();
            BoardImages = new Image[50, 50];


            for (int i = 0; i < 50; i++)
            {
                BoardGrid.RowDefinitions.Add(new RowDefinition());
                BoardGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            ResetBoard();
            StartBtn.Visibility = Visibility.Hidden;
            EndBtn.Visibility = Visibility.Visible;
            if (GetTextBoxValues(out int[] tab))
            {
                int[] position = new int[2];
                for (int i = 0; i < tab[0]; i++)
                {
                    if (AnimalList.Count<2500)
                    {
                        Antelope antelope = new Antelope();
                        position = antelope.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            antelope.SetPosition();
                            position = antelope.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Antelope.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(antelope);
                    }
                    
                }
                for (int i = 0; i < tab[1]; i++)
                {
                    if (AnimalList.Count<2500)
                    {
                        Cheetah cheetah = new Cheetah();
                        position = cheetah.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            cheetah.SetPosition();
                            position = cheetah.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Cheetah.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(cheetah);
                    }
                }
                for (int i = 0; i < tab[2]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Giraffe giraffe = new Giraffe();
                        position = giraffe.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            giraffe.SetPosition();
                            position = giraffe.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Giraffe.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(giraffe);
                    } 
                }
                for (int i = 0; i < tab[3]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Hyena hyena = new Hyena();
                        position = hyena.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            hyena.SetPosition();
                            position = hyena.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Hyena.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(hyena);
                    }
                }
                for (int i = 0; i < tab[4]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Lion lion = new Lion();
                        position = lion.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            lion.SetPosition();
                            position = lion.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Lion.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(lion);
                    }  
                }
                for (int i = 0; i < tab[5]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Zebra zebra = new Zebra();
                        position = zebra.GetPosition();
                        while (AnimalPositions[position[0], position[1]])
                        {
                            zebra.SetPosition();
                            position = zebra.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Zebra.jpg"));
                        AnimalPositions[position[0], position[1]] = true;
                        AnimalList.Add(zebra);
                    } 
                }
                for (int i = 0; i < tab[6]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Acacia acacia = new Acacia();
                        position = acacia.GetPosition();
                        while (PlantPositions[position[0], position[1]])
                        {
                            acacia.SetPosition();
                            position = acacia.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Acacia.png"));
                        PlantPositions[position[0], position[1]] = true;
                        PlantList.Add(acacia);
                    }
                }
                for (int i = 0; i < tab[7]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Aloe aloe = new Aloe();
                        position = aloe.GetPosition();
                        while (PlantPositions[position[0], position[1]])
                        {
                            aloe.SetPosition();
                            position = aloe.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Aloe.png"));
                        PlantPositions[position[0], position[1]] = true;
                        PlantList.Add(aloe);
                    }
                }
                for (int i = 0; i < tab[8]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Baobab baobab = new Baobab();
                        position = baobab.GetPosition();
                        while (PlantPositions[position[0], position[1]])
                        {
                            baobab.SetPosition();
                            position = baobab.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Baobab.png"));
                        PlantPositions[position[0], position[1]] = true;
                        PlantList.Add(baobab);
                    }
                }
                for (int i = 0; i < tab[9]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Grass grass = new Grass();
                        position = grass.GetPosition();
                        while (PlantPositions[position[0], position[1]])
                        {
                            grass.SetPosition();
                            position = grass.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Grass.png"));
                        PlantPositions[position[0], position[1]] = true;
                        PlantList.Add(grass);
                    }
                }
            }
        }

        private bool GetTextBoxValues(out int[] tab)
        {
            int value;
            tab = new int[10];
            if (!int.TryParse(AntelopeTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[0] = value;
            if (!int.TryParse(CheetahTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[1] = value;
            if (!int.TryParse(GiraffeTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[2] = value;
            if (!int.TryParse(HyenaTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[3] = value;
            if (!int.TryParse(LionTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[4] = value;
            if (!int.TryParse(ZebraTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[5] = value;
            if (!int.TryParse(AcaciaTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[6] = value;
            if (!int.TryParse(AloeTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[7] = value;
            if (!int.TryParse(BaobabTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[8] = value;
            if (!int.TryParse(GrassTB.Text, out value) && value < 0)
            {
                return false;
            }
            tab[9] = value;

            return true;
        }

        private void EndBtn_Click(object sender, RoutedEventArgs e)
        {
            EndBtn.Visibility = Visibility.Hidden;
            StartBtn.Visibility = Visibility.Visible;
        }

        private void ResetBoard()
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    BoardImages[i, j] = new Image();
                    BoardImages[i, j].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/EmptyFile.png"));
                    BoardGrid.Children.Add(BoardImages[i, j]);
                    Grid.SetRow(BoardImages[i, j], i);
                    Grid.SetColumn(BoardImages[i, j], j);
                }
            }
            AnimalPositions = new bool[50, 50];
            PlantPositions = new bool[50, 50];
            AnimalList = new List<Animal>();
            PlantList = new List<Plant>();
        }
    }
}
