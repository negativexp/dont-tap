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
using System.Timers;

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

        static int time;
        static int boardSize;
        static int boxSize;
        static int spacing;
        static int amountOfStartingBoxes;

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
            time = values[0];
            boardSize = values[1];
            boxSize = values[2];
            spacing = values[3];
            amountOfStartingBoxes = values[4];

            TextBlockTimeReal.Text = time.ToString();

            GenerateDefinitions();
            AdjustTextBoxSize();
            AdjustSize();
            AddBoxes();
            _mainWindow.IsEnabled = false;
            AddCountDown();
        }

        static System.Windows.Threading.DispatcherTimer timerCountDown = new System.Windows.Threading.DispatcherTimer();
        static System.Windows.Threading.DispatcherTimer timerProgressBar = new System.Windows.Threading.DispatcherTimer();
        static System.Windows.Threading.DispatcherTimer timerTime = new System.Windows.Threading.DispatcherTimer();
        static TextBlock text = new TextBlock();

        private void StartTime()
        {
            timerTime.Interval = new TimeSpan(0, 0, 1);
            timerTime.Tick += TimerTime_Tick;
            timerTime.Start();
        }

        //timer tick
        //Declares time remaining
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(TextBlockTimeReal.Text);
            number = number - 1;

            if (number == 0)
            {
                _mainWindow.IsEnabled = false;
                TextBlockTimeReal.Text = "0";
                GameOver();
            }
            else
            {
                TextBlockTimeReal.Text = number.ToString();
                TextBlockTimeReal.Text = number.ToString();
            }
        }

        //start progressBar
        private void StartProgressBar()
        {
            timerProgressBar.Interval = new TimeSpan(0, 0, 0, 0, 1);
            timerProgressBar.Tick += TimerProgressBar_Tick;
            timerProgressBar.Start();
        }

        //every 1 millisecons 0.45 gets removed from progressbar
        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            ProgressBarScore.Value = ProgressBarScore.Value - 0.45;
        }

        private void AddCountDown()
        {
            //text

            text.SetValue(Grid.ColumnSpanProperty, boardSize);
            text.SetValue(Grid.RowSpanProperty, boardSize);

            text.Background = new SolidColorBrush(Colors.Black);
            text.Background.Opacity = 0.7;
            text.Text = "3";
            text.FontSize = 140;
            text.TextAlignment = TextAlignment.Center;
            text.Width = 240;
            text.Height = 200;
            text.VerticalAlignment = VerticalAlignment.Center;
            text.HorizontalAlignment = HorizontalAlignment.Center;
            mainGrid.Children.Add(text);

            //timer
            timerCountDown.Interval = new TimeSpan(0, 0, 1);
            timerCountDown.Tick += Timer_Elapsed;
            timerCountDown.Start();
        }

        int number = 3;
        private void Timer_Elapsed(object sender, EventArgs e)
        {
            number = number - 1;
            text.Text = number.ToString();

            if (number == 0)
            {
                text.Text = "Go!";
            }
            if (number == -1)
            {
                mainGrid.Children.Remove(text);
                StartTime();
                GenerateFirstBoxes();
                StartProgressBar();
                _mainWindow.IsEnabled = true;
                timerCountDown.Stop();
            }
        }

        private void AddBoxes()
        {
            //all boxes
            boxes = new Rectangle[boardSize * boardSize];

            int index = -1;
            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    index++;

                    boxes[index] = GenerateLabel();
                    boxes[index].Tag = index;
                    boxes[index].MouseDown += Box_MouseDown;
                    boxes[index].SetValue(Grid.RowProperty, i);
                    boxes[index].SetValue(Grid.ColumnProperty, j);
                    mainGrid.Children.Add(boxes[index]);

                }
            }
        }

        //checks if box is clickable, if it is add points
        //if its not declare gameover
        private void Box_MouseDown(object sender, MouseEventArgs e)
        {
            int number = Convert.ToInt32((sender as Rectangle).Tag);

            if (!clickable[number])
            {
                _mainWindow.IsEnabled = false;
                GameOver();
            }
            else
            {
                clickable[number] = false;
                ChangeColorToNotClickable(boxes[number]);
                GenerateNewClickableBox(number);
                AddScore();
                ProgressBarScore.Value = ProgressBarScore.Value + 5.25;
                TextBlockPointsReal.Text = Points.ToString();
            }

        }

        private void AddScore()
        {
            if (ProgressBarScore.Value < 20)
                Points = Points + 1;
            if (ProgressBarScore.Value > 20)
                Points = Points + 2;
            if (ProgressBarScore.Value > 40)
                Points = Points + 3;
            if (ProgressBarScore.Value > 60)
                Points = Points + 4;
            if (ProgressBarScore.Value > 80)
                Points = Points + 4;

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

        private void GenerateDefinitions()
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

        private void AdjustTextBoxSize()
        {
            ProgressBarScore.SetValue(Grid.ColumnSpanProperty, boardSize);
            ProgressBarScore.SetValue(Grid.RowSpanProperty, boardSize);

            TextBlockPoints.SetValue(Grid.ColumnSpanProperty, boardSize);
            TextBlockPointsReal.SetValue(Grid.ColumnSpanProperty, boardSize);
            TextBlockTime.SetValue(Grid.ColumnProperty, boardSize - 1);
            TextBlockTimeReal.SetValue(Grid.ColumnProperty, boardSize - 1);
            TextBlockHiScore.SetValue(Grid.ColumnProperty, 0);

            ProgressBarScore.VerticalAlignment = VerticalAlignment.Bottom;
            TextBlockPoints.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockPointsReal.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockTime.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockTimeReal.HorizontalAlignment = HorizontalAlignment.Center;
            TextBlockHiScore.HorizontalAlignment = HorizontalAlignment.Center;

            TextBlockTime.Margin = new Thickness(0, -50, 0, 0);

            TextBlockHiScore.Margin = new Thickness(0, -100, 0, 0);
            ProgressBarScore.Margin = new Thickness(0, 0, 0, -50);
            TextBlockTime.Margin = new Thickness(0, -100, 0, 0);
            TextBlockTimeReal.Margin = new Thickness(0, -70, 0, 0);
            TextBlockPoints.Margin = new Thickness(0, -100, 0, 0);
            TextBlockPointsReal.Margin = new Thickness(0, -70, 0, 0);
        }

        private void AdjustSize()
        {
            this.Width = boardSize * boxSize + spacing;
            this.Height = boardSize * boxSize + spacing;

            _mainWindow.Height = boardSize * boxSize + 250 + spacing;
            _mainWindow.Width = boardSize * boxSize + 100 + spacing;

            mainGrid.Width = boardSize * boxSize + spacing;
            mainGrid.Height = boardSize * boxSize + spacing;
        }

        private Rectangle GenerateLabel()
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

        private void GenerateFirstBoxes()
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

        private void GameOver()
        {
            //ey goulg wher walma at
            //jogle: k
            //STOP THE COUNT
            timerTime.Stop();

            _mainWindow.FramePage.Content = new Viewmodels.GameOver.GameOver(_mainWindow, Points, 0);
        }
    }
}
