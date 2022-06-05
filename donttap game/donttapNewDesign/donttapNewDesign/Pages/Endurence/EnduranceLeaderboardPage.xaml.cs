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
using Newtonsoft.Json.Linq;
using System.Data;

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
        private async Task ReLoad()
        {
            Models.Data data = await Task.Run(() => Classes.LoadLeaderboardData.Load());
            DataGridMrdko.ItemsSource = data.Scores.Endurance;
            DataGridMrdko.Columns[1].Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Models.Data data = await Task.Run(() => Classes.LoadLeaderboardData.Load());
            DataGridMrdko.ItemsSource = data.Scores.Endurance;
            DataGridMrdko.Columns[1].Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.EnduranceSave bruh = DataGridMrdko.SelectedItem as Models.EnduranceSave;
            var data = JObject.Parse(File.ReadAllText("data.json"));
            var index = data["Scores"]["Endurance"].Select((x, index) => new { Time = x.Value<DateTime>("Time"), Node = x, Index = index })
                                                   .Single(x => x.Time == bruh.Time)
                                                   .Index;
            data["Scores"]["Endurance"][index].Remove();
            File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            ReLoad();
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
            _mainwindow.ChangeContent(3);
        }
    }
}
