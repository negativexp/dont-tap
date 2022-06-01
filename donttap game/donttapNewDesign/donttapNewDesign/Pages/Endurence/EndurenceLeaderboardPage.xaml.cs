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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
            DataGridMrdko.ItemsSource = data.Scores.Endurance;
            DataGridMrdko.Columns[1].Width = new DataGridLength(1.0, DataGridLengthUnitType.SizeToCells);
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            var test = JObject.Parse(File.ReadAllText("data.json"));
            var index = test["Scores"]["Endurance"].Select((x, index) => new { Score = x.Value<int>("Score"), Node = x, Index = index })
                                                   .Single(x => x.Score == DataGridMrdko.sele)
                                                   .Index;
            MessageBox.Show(index.ToString());


            //File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
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
