using ProjectSavanna.Model;
using ProjectSavanna.Model.PlantsModel;
using ProjectSavanna.Model.PlantsModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        short[,] AnimalPositions;
        short[,] PlantPositions;
        int[] position = new int[2];
        public MainWindow()
        {
            InitializeComponent();
            BoardImages = new Image[50, 50];
            AnimalPositions = new short[50, 50];
            PlantPositions = new short[50, 50];
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
            MoveBtn.Visibility = Visibility.Visible;
            EndBtn.Visibility = Visibility.Visible;
            AntelopeTB.IsEnabled = false;
            CheetahTB.IsEnabled = false;
            GiraffeTB.IsEnabled = false;
            HyenaTB.IsEnabled = false;
            LionTB.IsEnabled = false;
            ZebraTB.IsEnabled = false;
            AcaciaTB.IsEnabled = false;
            AloeTB.IsEnabled = false;
            BaobabTB.IsEnabled = false;
            GrassTB.IsEnabled = false;
            if (GetTextBoxValues(out int[] tab))
            {
                
                for (int i = 0; i < tab[0]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Antelope antelope = new Antelope();
                        position = antelope.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            antelope.SetPosition();
                            position = antelope.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Antelope.jpg"));
                        AnimalPositions[position[0], position[1]] = 1;
                        AnimalList.Add(antelope);
                    }

                }
                for (int i = 0; i < tab[1]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Cheetah cheetah = new Cheetah();
                        position = cheetah.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            cheetah.SetPosition();
                            position = cheetah.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Cheetah.jpg"));
                        AnimalPositions[position[0], position[1]] = 2;
                        AnimalList.Add(cheetah);
                    }
                }
                for (int i = 0; i < tab[2]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Giraffe giraffe = new Giraffe();
                        position = giraffe.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            giraffe.SetPosition();
                            position = giraffe.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Giraffe.jpg"));
                        AnimalPositions[position[0], position[1]] = 1;
                        AnimalList.Add(giraffe);
                    }
                }
                for (int i = 0; i < tab[3]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Hyena hyena = new Hyena();
                        position = hyena.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            hyena.SetPosition();
                            position = hyena.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Hyena.jpg"));
                        AnimalPositions[position[0], position[1]] = 2;
                        AnimalList.Add(hyena);
                    }
                }
                for (int i = 0; i < tab[4]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Lion lion = new Lion();
                        position = lion.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            lion.SetPosition();
                            position = lion.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Lion.jpg"));
                        AnimalPositions[position[0], position[1]] = 2;
                        AnimalList.Add(lion);
                    }
                }
                for (int i = 0; i < tab[5]; i++)
                {
                    if (AnimalList.Count < 2500)
                    {
                        Zebra zebra = new Zebra();
                        position = zebra.GetPosition();
                        while (AnimalPositions[position[0], position[1]]!=0)
                        {
                            zebra.SetPosition();
                            position = zebra.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Zebra.jpg"));
                        AnimalPositions[position[0], position[1]] = 1;
                        AnimalList.Add(zebra);
                    }
                }
                for (int i = 0; i < tab[6]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Acacia acacia = new Acacia();
                        position = acacia.GetPosition();
                        while (PlantPositions[position[0], position[1]]!=0)
                        {
                            acacia.SetPosition();
                            position = acacia.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Acacia.png"));
                        PlantPositions[position[0], position[1]] = 2;
                        PlantList.Add(acacia);
                    }
                }
                for (int i = 0; i < tab[7]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Aloe aloe = new Aloe();
                        position = aloe.GetPosition();
                        while (PlantPositions[position[0], position[1]]!=0)
                        {
                            aloe.SetPosition();
                            position = aloe.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Aloe.png"));
                        PlantPositions[position[0], position[1]] = 1;
                        PlantList.Add(aloe);
                    }
                }
                for (int i = 0; i < tab[8]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Baobab baobab = new Baobab();
                        position = baobab.GetPosition();
                        while (PlantPositions[position[0], position[1]]!=0)
                        {
                            baobab.SetPosition();
                            position = baobab.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Baobab.png"));
                        PlantPositions[position[0], position[1]] = 2;
                        PlantList.Add(baobab);
                    }
                }
                for (int i = 0; i < tab[9]; i++)
                {
                    if (PlantList.Count < 2500)
                    {
                        Grass grass = new Grass();
                        position = grass.GetPosition();
                        while (PlantPositions[position[0], position[1]]!=0)
                        {
                            grass.SetPosition();
                            position = grass.GetPosition();
                        }
                        BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/Grass.png"));
                        PlantPositions[position[0], position[1]] = 1;
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
            MoveBtn.Visibility = Visibility.Hidden;
            EndBtn.Visibility = Visibility.Hidden;
            StartBtn.Visibility = Visibility.Visible;
            AntelopeTB.IsEnabled = true;
            CheetahTB.IsEnabled = true;
            GiraffeTB.IsEnabled = true;
            HyenaTB.IsEnabled = true;
            LionTB.IsEnabled = true;
            ZebraTB.IsEnabled = true;
            AcaciaTB.IsEnabled = true;
            AloeTB.IsEnabled = true;
            BaobabTB.IsEnabled = true;
            GrassTB.IsEnabled = true;
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
            AnimalPositions = new short[50, 50];
            PlantPositions = new short[50, 50];
            AnimalList = new List<Animal>();
            PlantList = new List<Plant>();
        }

        private void MoveBtn_Click(object sender, RoutedEventArgs e)
        {
            List<Animal> DeadAnimals = new List<Animal>();
            List<Plant> NewPlants = new List<Plant>();
            foreach (var plant in PlantList)
            {
                position = plant.GetPosition();
                int sight = plant.NewTurn();

                if (sight != 0)
                {
                    Plant newPlant;
                    if (plant.Name == "Acacia")
                    {
                        newPlant = new Acacia();
                        newPlant.SetPosition(position, sight);
                    }
                    else if (plant.Name == "Aloe")
                    {
                        newPlant = new Aloe();
                        newPlant.SetPosition(position, sight);
                    }
                    else if (plant.Name == "Baobab")
                    {
                        newPlant = new Baobab();
                        newPlant.SetPosition(position, sight);
                    }
                    else
                    {
                        newPlant = new Grass();
                        newPlant.SetPosition(position, sight);
                    }
                    position = newPlant.GetPosition();
                    if (PlantPositions[position[0], position[1]] == 0)
                    {
                        NewPlants.Add(newPlant);
                        if (plant.Name == "Acacia")
                        {
                            PlantPositions[position[0], position[1]] = 2;
                            AcaciaTB.Text = (int.Parse(AcaciaTB.Text) + 1).ToString();
                        }
                        else if (plant.Name == "Baobab")
                        {
                            PlantPositions[position[0], position[1]] = 2;
                            BaobabTB.Text = (int.Parse(BaobabTB.Text) + 1).ToString();
                        }
                        else if (plant.Name == "Grass")
                        {
                            PlantPositions[position[0], position[1]] = 1;
                            GrassTB.Text = (int.Parse(GrassTB.Text) + 1).ToString();
                        }
                        else
                        {
                            PlantPositions[position[0], position[1]] = 1;
                            AloeTB.Text = (int.Parse(AloeTB.Text) + 1).ToString();
                        }
                    }
                }
                if (AnimalPositions[position[0], position[1]] == 0)
                {
                    BoardImages[position[0], position[1]].Source = plant.GetImageSource();
                }
            }
            foreach (var plant in NewPlants)
            {
                PlantList.Add(plant);
            }
            foreach (var animal in AnimalList)
            {
                position = animal.GetPosition();
                if (animal.IsAlive())
                {
                    if (animal.IsHuntTime)
                    {
                        if (animal.IsHerbivores)
                        {
                            if (AnimalPositions[position[0], position[1]] == 2)
                            {
                                animal.IsHunted();
                            }
                        }
                        else
                        {
                            int[] newHuntPosition = UpdateHuntPosition(position);
                            if (newHuntPosition.Length == 2)
                            {
                                animal.StartHunt(newHuntPosition[0], newHuntPosition[1]);
                            }
                        }
                    }
                    AnimalPositions[position[0], position[1]] = 0;
                    BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/EmptyFile.png"));

                    if (!animal.IsHuntTime)
                    {
                        int[] huntPosition = CheckHuntTime(position, animal.Sight, animal.IsHerbivores);
                        if (huntPosition[0] != position[0] || huntPosition[1] != position[1])
                        {
                            animal.StartHunt(huntPosition[0], huntPosition[1]);
                        }
                    }

                    if (animal.IsHuntTime)
                    {
                        int[] lastPosition;
                        if (animal.IsHerbivores)
                        {
                            lastPosition = animal.GetPosition();

                            animal.Move();
                            position = animal.GetPosition();
                            if (AnimalPositions[position[0], position[1]] != 0)
                            {
                                animal.SetPosition(lastPosition[0], lastPosition[1]);
                                position[0] = lastPosition[0];
                                position[1] = lastPosition[1];
                            }
                            if (animal.EatHerbs)
                            {
                                if (PlantPositions[position[0], position[1]] == 1)
                                {
                                    Plant plant = PlantList.Where(p => p.PositionX == position[0] && p.PositionY == position[1]).FirstOrDefault();
                                    animal.Eat(plant.HPRestore);
                                    PlantPositions[position[0], position[1]] = 0;
                                    PlantList.Remove(plant);
                                    if (plant.Name == "Aloe")
                                    {
                                        AloeTB.Text = (int.Parse(AloeTB.Text) - 1).ToString();
                                    }
                                    else if (plant.Name == "Grass")
                                    {
                                        GrassTB.Text = (int.Parse(GrassTB.Text) - 1).ToString();
                                    }
                                }
                            }
                            if (animal.EatTrees)
                            {
                                if (PlantPositions[position[0], position[1]] == 2)
                                {
                                    Plant plant = PlantList.Where(p => p.PositionX == position[0] && p.PositionY == position[1]).FirstOrDefault();
                                    animal.Eat(plant.HPRestore);
                                    PlantPositions[position[0], position[1]] = 0;
                                    PlantList.Remove(plant);
                                    if (plant.Name == "Acacia")
                                    {
                                        AcaciaTB.Text = (int.Parse(AcaciaTB.Text) - 1).ToString();
                                    }
                                    else if (plant.Name == "Baobab")
                                    {
                                        BaobabTB.Text = (int.Parse(BaobabTB.Text) - 1).ToString();
                                    }
                                }
                            }
                            AnimalPositions[position[0], position[1]] = 1;

                        }
                        else
                        {
                            
                            lastPosition = animal.GetPosition();
                            animal.Move();
                            position = animal.GetPosition();
                            if (AnimalPositions[position[0], position[1]] == 2)
                            {
                                animal.SetPosition(lastPosition[0], lastPosition[1]);
                                position[0] = lastPosition[0];
                                position[1] = lastPosition[1];
                            }

                            if (AnimalPositions[position[0], position[1]] == 1)
                            {
                                animal.IsHunted();
                            }
                            AnimalPositions[position[0], position[1]] = 2;
                        }
                    }
                    else
                    {
                        animal.Move();
                        int[] newPosition = animal.GetPosition();
                        if (AnimalPositions[position[0], position[1]] == 0)
                        {
                            position[0] = newPosition[0];
                            position[1] = newPosition[1];
                        }
                        //do
                        //{
                        //    animal.Move();
                        //    position = animal.GetPosition();
                        //} while (AnimalPositions[position[0], position[1]] != 0);
                    }

                    BoardImages[position[0], position[1]].Source = animal.GetImageSource();
                    

                }
                else
                {
                    DeadAnimals.Add(animal);
                    position = animal.GetPosition();
                    AnimalPositions[position[0], position[1]] = 0;
                    BoardImages[position[0], position[1]].Source = new BitmapImage(new Uri(@"pack://application:,,,/Image/EmptyFile.png"));
                    if (animal.Name == "Antelope")
                    {
                        AntelopeTB.Text = (int.Parse(AntelopeTB.Text) - 1).ToString();
                    }
                    else if (animal.Name == "Cheetah")
                    {
                        CheetahTB.Text = (int.Parse(CheetahTB.Text) - 1).ToString();
                    }
                    else if (animal.Name == "Giraffe")
                    {
                        GiraffeTB.Text = (int.Parse(GiraffeTB.Text) - 1).ToString();
                    }
                    else if (animal.Name == "Hyena")
                    {
                        HyenaTB.Text = (int.Parse(HyenaTB.Text) - 1).ToString();
                    }
                    else if (animal.Name == "Lion")
                    {
                        LionTB.Text = (int.Parse(LionTB.Text) - 1).ToString();
                    }
                    else if (animal.Name == "Zebra")
                    {
                        ZebraTB.Text = (int.Parse(ZebraTB.Text) - 1).ToString();
                    }
                }
            }
            foreach (var dead in DeadAnimals)
            {
                AnimalList.Remove(dead);
            }
            
        }

        private int[] CheckHuntTime(int[] position,int sight, bool isHerbivores)
        {
            int posX = position[0];
            int posY = position[1];
            short hunt;
            if (isHerbivores)
            {
                hunt = 2;
            }
            else
            {
                hunt = 1;
            }

            for (int i = posX-sight; i <= posX+sight; i++)
            {
                if (i>-1 && i<50)
                {
                    for (int j = posY-sight; j < posY + sight; j++)
                    {
                        if (j > -1 && j < 50)
                        {
                            if (AnimalPositions[i,j] == hunt)
                            {
                                return new int[] { i,j};
                            }
                        }
                    }
                }
            }
            return position;
        }
        private int[] UpdateHuntPosition(int[] lastHuntPosition)
        {

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (lastHuntPosition[0]-i>=0 && lastHuntPosition[0] - i < 50)
                    {
                        if (lastHuntPosition[1] - j >= 0 && lastHuntPosition[1] - j < 50)
                        {
                            if (AnimalPositions[lastHuntPosition[0] - i, lastHuntPosition[1] - j] == 1)
                            {
                                return new int[] { lastHuntPosition[0] - i, lastHuntPosition[1] - j };
                            }
                        }
                    }
                }
            }
            return new int[] { 0 };
        }
    }
}
