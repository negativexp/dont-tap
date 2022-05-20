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
using Newtonsoft.Json;
using System.IO;

namespace donttapNewDesign.Pages
{
    /// <summary>
    /// Interakční logika pro SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        private readonly MainWindow _mainwindow;
        public SettingsPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }
        int epicprank = 0;
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int boxsize = Convert.ToInt32(TextBoxBoxSize.Text);
                int boardsize = Convert.ToInt32(TextBoxBoardSize.Text);
                int spacing = Convert.ToInt32(TextBoxSpacingSize.Text);

                if (File.Exists("settings.json"))
                {
                    var data = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));
                    data.Boxsize = boxsize;
                    data.Boardsize = boardsize;
                    data.Spacing = spacing;
                    File.WriteAllText("settings.json", JsonConvert.SerializeObject(data));
                }
                else
                {
                    Models.Settings settings = new Models.Settings();
                    settings.Boardsize = boardsize;
                    settings.Boxsize = boxsize;
                    settings.Spacing = spacing;
                    File.WriteAllText("settings.json", JsonConvert.SerializeObject(settings));
                }
                _mainwindow.ChangeContent(0);
            }
            catch (Exception ex)
            {
                if(epicprank == 4)
                {
                    MessageBox.Show("are you retarted", "bruh");
                    epicprank = 0;
                }
                else
                {
                    MessageBox.Show("Please make sure you typed in only numbers!", "Value ERROR");
                    epicprank++;
                }
            }

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if(File.Exists("settings.json"))
            {
                int[] data = Classes.LoadSettings.Load();
                TextBoxBoardSize.Text = data[0].ToString();
                TextBoxBoxSize.Text = data[1].ToString();
                TextBoxSpacingSize.Text = data[2].ToString();
            }
        }
    }
}
