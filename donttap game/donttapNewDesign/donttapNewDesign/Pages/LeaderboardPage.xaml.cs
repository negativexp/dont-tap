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
            public string score { get; set; }
            public string gamemode { get; set; }
            public string settings { get; set; }
            public string time { get; set; }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var result = JsonConvert.DeserializeObject<Models.PlayerSave>(File.ReadAllText("scores.json"));
            DataGridScores.DataContext = result;
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
