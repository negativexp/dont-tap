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
    /// Interakční logika pro EndurenceLeaderboardPage.xaml
    /// </summary>
    public partial class EndurenceLeaderboardPage : Page
    {
        private readonly MainWindow _mainwindow;
        public EndurenceLeaderboardPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        public class data
        {
            public int Score { get; set; }
            public string Settings { get; set; }
            public string Time { get; set; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var json = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
                List<data> mrdko = new List<data>();

                foreach (var item in json.Endurence)
                {
                    string gr = string.Format("Board size:  {0}\nBox size:  {1}\nSpacing:  {2}\nClicks:  {3}", item.Boardsize, item.Boxsize, item.Spacing, item.Clicks);
                    mrdko.Add(new data
                    {
                        Score = item.Score,
                        Settings = gr,
                        Time = item.Time.ToShortDateString() + "\n" + item.Time.ToShortTimeString()
                    });
                }

                DataGridScores.ItemsSource = mrdko;
                foreach (var col in DataGridScores.Columns)
                {
                    col.Width = new DataGridLength(1, DataGridLengthUnitType.Star);
                }
            }
            catch (Exception)
            {

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
