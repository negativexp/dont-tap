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

namespace donttapNewDesign.Pages.Frenzy
{
    /// <summary>
    /// Interakční logika pro FrenzyGame.xaml
    /// </summary>
    public partial class FrenzyGame : Page
    {
        private readonly MainWindow _mainwindow;
        public FrenzyGame(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        bool[] clickables;
        int[] inUse;
        Rectangle[] boxes;
        int time;
        int boxSize;
        int boardSize;
        int spacing;
        int points;
        int countdown = 3;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));

            int width = (data.Settings.Boardsize * data.Settings.Boxsize) + (data.Settings.Boardsize * data.Settings.Spacing);
            int height = (data.Settings.Boardsize * data.Settings.Boxsize) + (data.Settings.Boardsize * data.Settings.Spacing);

            _mainwindow.Width = width + 100;
            _mainwindow.Height = height + 250;
            this.Width = width + 100;
            this.Height = height + 250;
            GridGame.Width = width;
            GridGame.Height = height;
            ProgessBarValue.Width = width;

            if (this.Width < Convert.ToInt32(Application.Current.FindResource("Width")) | this.Height < Convert.ToInt32(Application.Current.FindResource("Height")))
            {
                this.Width = Convert.ToInt32(Application.Current.FindResource("Wídth"));
                this.Height = Convert.ToInt32(Application.Current.FindResource("Height"));
                _mainwindow.Width = Convert.ToInt32(Application.Current.FindResource("Wídth"));
                _mainwindow.Height = Convert.ToInt32(Application.Current.FindResource("Height"));
                ProgessBarValue.Width = 400;
            }

            //set values
            inUse = new int[3];
            time = data.FrenzySettings.GameTime;
            boxSize = data.Settings.Boxsize;
            boardSize = data.Settings.Boardsize;
            spacing = data.Settings.Spacing;
            time = data.FrenzySettings.GameTime;
            TextBlockTime.Text = time.ToString();

            CreateDefinitions();
            CreateBoard();
            StartCountDown();
        }
        private void CreateDefinitions()
        {
            //row
            for (int i = 0; i < boardSize; i++)
            {
                RowDefinition row = new RowDefinition();
                GridGame.RowDefinitions.Add(row);
            }
            for (int i = 0; i < boardSize; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                GridGame.ColumnDefinitions.Add(col);
            }
        }
        private void CreateBoard()
        {
            boxes = new Rectangle[boardSize * boardSize];

            int index = -1;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    index++;
                    boxes[index] = RectangleSettings();
                    boxes[index].Tag = index;
                    boxes[index].Style = Application.Current.FindResource("bruh") as Style;
                    boxes[index].SetValue(Grid.RowProperty, i);
                    boxes[index].SetValue(Grid.ColumnProperty, j);
                    GridGame.Children.Add(boxes[index]);
                }
            }
        }
        private void Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int number = Convert.ToInt32((sender as Rectangle).Tag);
            if (clickables[number])
            {
                GameRules();
                UpdateTimeAndPoints();
                clickables[number] = false;
                //ChangeColorToNotClickable(boxes[number]);
                GenerateNewBox(number);
            }
            else
            {
                GameOver();
            }
        }
        System.Windows.Threading.DispatcherTimer TimerProgessBar = new System.Windows.Threading.DispatcherTimer();
        private void StartProgessBar()
        {
            TimerProgessBar.Tick += new EventHandler(TimerProgessBar_Tick);
            TimerProgessBar.Interval = new TimeSpan(0, 0, 0, 0, 1);
            TimerProgessBar.Start();
        }
        private void TimerProgessBar_Tick(object? sender, EventArgs e)
        {
            ProgessBarValue.Value -= 0.8;
        }
        private void UpdateTimeAndPoints()
        {
            TextBlockPoints.Text = points.ToString();
            TextBlockTime.Text = time.ToString();
        }
        private void GameRules()
        {
            ProgessBarValue.Value += 8;
            if (ProgessBarValue.Value < 25)
                points++;
            if (ProgessBarValue.Value > 25)
                points+=2;
            if (ProgessBarValue.Value > 50)
                points += 3;
            if (ProgessBarValue.Value > 75)
                points += 4;
            if (ProgessBarValue.Value > 90)
                points += 5;

        }
        private void GenerateNewBox(int clicked)
        {
            Random rdm = new Random();
            int index = Array.IndexOf(inUse, clicked);
            int number = rdm.Next(0, boxes.Length);
            while (inUse.Contains(number))
                number = rdm.Next(0, boxes.Length);
            inUse[index] = number;
            clickables[number] = true;
            ChangeColorToClickable(boxes[number]);
        }
        private void GenerateFirstBoxes()
        {
            clickables = new bool[boardSize * boardSize];

            Random rdm = new Random();
            for (int i = 0; i < inUse.Length; i++)
            {
                int number = rdm.Next(0, boardSize * boardSize);
                while (inUse.Contains(number))
                    number = rdm.Next(0, boardSize * boardSize);
                inUse[i] = number;
                clickables[number] = true;
                ChangeColorToClickable(boxes[number]);
            }
        }
        private Rectangle RectangleSettings()
        {
            Rectangle box = new Rectangle();
            box.Fill = new SolidColorBrush(Colors.White);
            box.Width = (double)boxSize;
            box.Height = (double)boxSize;

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
        System.Windows.Threading.DispatcherTimer TimerTime = new System.Windows.Threading.DispatcherTimer();
        private void StartTime()
        {
            TimerTime.Tick += new EventHandler(TimerTime_Tick);
            TimerTime.Interval = new TimeSpan(0, 0, 1);
            TimerTime.Start();
        }
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            time--;
            TextBlockTime.Text = time.ToString();
            if (time == 0)
            {
                GameOver();
                TimerTime.Stop();
            }
        }

        System.Windows.Threading.DispatcherTimer TimerCountDown = new System.Windows.Threading.DispatcherTimer();
        private void StartCountDown()
        {
            TimerCountDown.Tick += new EventHandler(TimerCountDown_Tick);
            TimerCountDown.Interval = new TimeSpan(0, 0, 1);
            TimerCountDown.Start();
        }
        private void TimerCountDown_Tick(object sender, EventArgs e)
        {
            countdown--;
            if (countdown == -1)
            {
                GridCountDown.Visibility = Visibility.Hidden;
                foreach (Rectangle r in boxes)
                    r.MouseDown += Box_MouseDown;
                GenerateFirstBoxes();
                StartProgessBar();
                StartTime();
                TimerCountDown.Stop();
            }
            TextBlockCountDown.Text = countdown.ToString();
            if (countdown == 0)
            {
                TextBlockCountDown.Text = "Go!";
            }
        }
        System.Windows.Threading.DispatcherTimer TimerGameOver = new System.Windows.Threading.DispatcherTimer();
        private void GameOver()
        {
            Classes.CreatePlayerScore.Create(1, points);
            foreach (Rectangle bruh in boxes)
            {
                bruh.MouseDown -= Box_MouseDown;
                bruh.Style = null;
            }
            TimerTime.Stop();
            TimerProgessBar.Stop();
            GridCountDown.Visibility = Visibility.Visible;
            TextBlockCountDown.Text = "Game\nOver";
            TimerGameOver.Tick += new EventHandler(TimerGameOver_Tick);
            TimerGameOver.Interval = new TimeSpan(0, 0, 2);
            TimerGameOver.Start();
        }
        private void TimerGameOver_Tick(object sender, EventArgs e)
        {
            _mainwindow.ChangeContent(4);
            Reset();
            TimerGameOver.Stop();
        }
        private void Reset()
        {
            clickables = null;
            inUse = null;
            boxes = null;
            countdown = 3;
        }
    }
}
