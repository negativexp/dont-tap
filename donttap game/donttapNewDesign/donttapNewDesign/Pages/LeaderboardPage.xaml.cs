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

namespace donttapNewDesign.Pages
{
    /// <summary>
    /// Interakční logika pro LeaderboardPage.xaml
    /// </summary>
    public partial class LeaderboardPage : Page
    {
        private readonly MainWindow _mainwindow;
        public LeaderboardPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }
        public class data
        {
            public int Score { get; set; }
            public string Gamemode { get; set; }
            public string Settings { get; set; }
            public string Time { get; set; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var json = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
            List<data> mrdko = new List<data>();

            foreach(var item in json.Endurence)
            {
                string gr = string.Format("{0}\n{1}\n{2}\n{3}", item.Boardsize, item.Boxsize, item.Spacing, item.Clicks);
                mrdko.Add(new data
                {
                    Score = item.Score,
                    Gamemode = "Endurence",
                    Settings = gr,
                    Time = item.Time.ToShortDateString() + "\n" + item.Time.ToShortTimeString()
                });
            }

            DataGridScores.ItemsSource = mrdko;
            foreach(var col in DataGridScores.Columns)
            {
                col.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }
    }
}
