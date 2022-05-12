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
using System.IO;
using Newtonsoft.Json;

namespace donttap.Viewmodels.Endurence.Game
{
    /// <summary>
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        private readonly MainWindow _mainWindow;
        public Game(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        static Rectangle[] boxes;
        static int[] inUse;
        static bool[] clickable;
        static int Points;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GameStart(sender);
        }

        private int[] GetSettingsData()
        {
            var data = File.ReadAllText("data/settings.json");
            Models.Settings settings = JsonConvert.DeserializeObject<Models.Settings>(data);
            int[] values = { settings.time, settings.boardSize, settings.boxSize, settings.spacing, settings.amountOfStartingBoxes };
            return values;
        }

        private void GameStart(object sender)
        {
            int[] values = GetSettingsData();
            int time = values[0];
            int boardSize = values[1];
            int boxSize = values[2];
            int spacing = values[3];
            int amountOfStartingBoxes = values[4];

            MessageBox.Show(string.Format("time: {0} \n" +
                                          "board size: {1} \n" +
                                          "box size: {2} \n" +
                                          "spacing: {3} \n" +
                                          "aosb: {4}", values[0], values[1], values[2], values[3], values[4]));
            

            GenerateDefinitions(boardSize);
            AdjustSize(boardSize, boxSize, spacing);
            AddBoxes(boardSize, boxSize);
            GenerateFirstBoxes(amountOfStartingBoxes, boardSize);
        }
        
        private void AddBoxes(int boardSize, int boxSize)
        {
            //all boxes
            boxes = new Rectangle[boardSize * boardSize];

            int index = -1;
            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    index++;

                    boxes[index] = GenerateLabel(boxSize);
                    boxes[index].Tag = index;
                    boxes[index].MouseDown += Box_MouseDown;
                    boxes[index].SetValue(Grid.RowProperty, i);
                    boxes[index].SetValue(Grid.ColumnProperty, j);
                    mainGrid.Children.Add(boxes[index]);

                }
            }
        }

        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int number = Convert.ToInt32((sender as Rectangle).Tag);

            if (!clickable[number])
                MessageBox.Show("spatne mrdko");
            else
            {
                clickable[number] = false;
                ChangeColorToNotClickable(boxes[number]);
                GenerateNewClickableBox(number);
                Points++;
                TextBlockPointsReal.Text = Points.ToString();
            }

        }

        private void GenerateNewClickableBox(int clicked)
        {
            Random rdm = new Random();

            int index = Array.IndexOf(inUse, clicked);
            int number = rdm.Next(0, boxes.Length);

            while (inUse.Contains(number))
                number = rdm.Next(0, boxes.Length);

            inUse[index] = number;
            clickable[number] = true;
            ChangeColorToClickable(boxes[number]);

        }

        private void GenerateDefinitions(int boardSize)
        {
            for(int i = 0; i < boardSize; i++)
            {
                RowDefinition row = new RowDefinition();
                mainGrid.RowDefinitions.Add(row);
            }

            for (int i = 0; i < boardSize; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                mainGrid.ColumnDefinitions.Add(col);
            }
        }

        private void AdjustSize(int boardSize, int boxSize, int spacing)
        {


            this.Width = boardSize * boxSize + spacing;
            this.Height = boardSize * boxSize + spacing;
            _mainWindow.Height = boardSize * boxSize + 250 + spacing;
            _mainWindow.Width = boardSize * boxSize + 100 + spacing;

            ProgressBarScore.SetValue(Grid.ColumnSpanProperty, boardSize);
            ProgressBarScore.SetValue(Grid.RowSpanProperty, boardSize);

            TextBlockPoints.SetValue(Grid.ColumnSpanProperty, boardSize);
            TextBlockPointsReal.SetValue(Grid.ColumnSpanProperty, boardSize);
            TextBlockTime.SetValue(Grid.ColumnProperty, boardSize-1);
            TextBlockHiScore.SetValue(Grid.ColumnProperty, 0);

            ProgressBarScore.VerticalAlignment = VerticalAlignment.Bottom;
            TextBlockPoints.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockPointsReal.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockTime.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockHiScore.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlockHiScore.Margin = new Thickness(0, -100, 0, 0);
            ProgressBarScore.Margin = new Thickness(0, 0, 0, -50);
            TextBlockTime.Margin = new Thickness(0, -100, 0, 0);
            TextBlockPoints.Margin = new Thickness(0, -100, 0, 0);
            TextBlockPointsReal.Margin = new Thickness(0, -70, 0, 0);

            mainGrid.Width = boardSize * boxSize + spacing;
            mainGrid.Height = boardSize * boxSize + spacing;
        }

        private Rectangle GenerateLabel(int boxSize)
        {
            Rectangle box = new Rectangle();
            box.Width = boxSize;
            box.Height = boxSize;
            box.HorizontalAlignment = HorizontalAlignment.Center;
            box.VerticalAlignment = VerticalAlignment.Center;
            box.Fill = new SolidColorBrush(Colors.White);
            return box;
        }

        private void ChangeColorToClickable(Rectangle box)
        {
            box.Fill = new SolidColorBrush(Colors.Black);
        }
        private void ChangeColorToNotClickable(Rectangle box)
        {
            box.Fill = new SolidColorBrush(Colors.White);
        }

        private void GenerateFirstBoxes(int amountOfStartingBoxes, int boardSize)
        {
            clickable = new bool[boardSize * boardSize];
            inUse = new int[amountOfStartingBoxes];
            Random rdm = new Random();

            for(int i = 0; i < inUse.Length; i++)
            {
                int number = rdm.Next(0, boardSize * boardSize);

                while (inUse.Contains(number))
                    number = rdm.Next(0, boardSize * boardSize);

                inUse[i] = number;
                clickable[number] = true;
                ChangeColorToClickable(boxes[number]);
            }
        }
    }
}
