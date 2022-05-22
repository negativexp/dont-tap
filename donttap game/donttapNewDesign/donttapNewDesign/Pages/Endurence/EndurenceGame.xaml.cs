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

namespace donttapNewDesign.Pages.Endurence
{
    /// <summary>
    /// Interakční logika pro EndurenceGame.xaml
    /// </summary>
    public partial class EndurenceGame : Page
    {
        private readonly MainWindow _mainwindow;
        public EndurenceGame(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        static bool[]? clickables;
        static Rectangle[]? boxes;
        static int? time;
        static int? boxSize;
        static int? boardSize;
        static int? spacing;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var settings = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));

            //change window size
            _mainwindow.Width = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing) + 100;
            _mainwindow.Height = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing) + 250;
            this.Width = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing) + 100;
            this.Height = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing) + 250;
            GridGame.Width = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing);
            GridGame.Height = (settings.Boardsize * settings.Boxsize) + (settings.Boardsize * settings.Spacing);

            if(this.Width < 355)
            {
                this.Width = 355;
                this.Height = 505;
                _mainwindow.Width = 355;
                _mainwindow.Height = 505;
            }

            //set values
            clickables = new bool[settings.Boardsize * settings.Boardsize];
            boxes = new Rectangle[settings.Boardsize * settings.Boxsize];
            time = 10;
            boxSize = settings.Boxsize;
            boardSize = settings.Boardsize;
            spacing = settings.Spacing;

            CreateDefinitions();
            CreateBoard();

        }

        private void CreateDefinitions()
        {
            //row
            for(int i = 0; i < boardSize; i++)
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
            int index = -1;
            for(int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    index++;
                    boxes[index] = RectangleSettings();
                    boxes[index].SetValue(Grid.RowProperty, i);
                    boxes[index].SetValue(Grid.ColumnProperty, j);
                    GridGame.Children.Add(boxes[index]);
                }
            }
        }
        private Rectangle RectangleSettings()
        {
            Rectangle box = new Rectangle();
            box.Fill = new SolidColorBrush(Colors.Black);
            box.Width = (double)boxSize;
            box.Height = (double)boxSize;

            return box;

        }

        private void Reset()
        {
            clickables = null;
            boxes = null;
            time = null;
            boxSize = null;
            boardSize = null;
            spacing = null;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }
    }
}
