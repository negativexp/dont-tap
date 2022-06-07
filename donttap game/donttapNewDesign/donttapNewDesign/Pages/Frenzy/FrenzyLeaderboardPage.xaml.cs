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

namespace donttapNewDesign.Pages.Frenzy
{
    /// <summary>
    /// Interakční logika pro FrenzyLeaderboardPage.xaml
    /// </summary>
    public partial class FrenzyLeaderboardPage : Page
    {
        private readonly MainWindow _mainwindow;
        public FrenzyLeaderboardPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }
        private async void ReLoad()
        {
            Models.Data data = await Task.Run(() => Classes.LoadLeaderboardData.Load());
            DataGridMrdko.ItemsSource = data.Scores.Frenzy;
            DataGridMrdko.Columns[1].Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Models.Data data = await Task.Run(() => Classes.LoadLeaderboardData.Load());
            DataGridMrdko.ItemsSource = data.Scores.Frenzy;
            DataGridMrdko.Columns[1].Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Models.FrenzySave bruh = DataGridMrdko.SelectedItem as Models.FrenzySave;
            var data = JObject.Parse(File.ReadAllText("data.json"));
            var index = data["Scores"]["Frenzy"].Select((x, index) => new { Time = x.Value<DateTime>("Time"), Node = x, Index = index })
                                                   .Single(x => x.Time == bruh.Time)
                                                   .Index;
            data["Scores"]["Frenzy"][index].Remove();
            File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            ReLoad();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(4);
        }
    }
}
