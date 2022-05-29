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
        private async void LoadData()
        {
            int[] data = Classes.LoadSettings.Load();
            TextBoxBoardSize.Text = data[0].ToString();
            TextBoxBoxSize.Text = data[1].ToString();
            TextBoxSpacingSize.Text = data[2].ToString();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }
        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }
        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }
        int epicprank = 0;
        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxBoardSize.Text == "" || TextBoxBoardSize.Text[0] == '0')
                TextBoxBoardSize.Text = "4";

            if (TextBoxBoxSize.Text == "" || TextBoxBoxSize.Text[0] == '0')
                TextBoxBoxSize.Text = "165";

            if (TextBoxSpacingSize.Text == "" || TextBoxSpacingSize.Text[0] == '0')
                TextBoxSpacingSize.Text = "0";

            try
            {
                int boxsize = Convert.ToInt32(TextBoxBoxSize.Text);
                if (boxsize < 0)
                    boxsize = 165;
                int boardsize = Convert.ToInt32(TextBoxBoardSize.Text);
                if (boardsize < 0)
                    boardsize = 4;
                int spacing = Convert.ToInt32(TextBoxSpacingSize.Text);
                if (spacing < 0)
                    spacing = 0;

                bool create;

                Models.Data data = JsonConvert.DeserializeObject<Models.Data>(File.ReadAllText("data.json"));
                data.Settings = new Models.Settings();
                data.Settings.Boxsize = boxsize;
                data.Settings.Boardsize = boardsize;
                data.Settings.Spacing = spacing;
                File.WriteAllText("data.json", JsonConvert.SerializeObject(data, Formatting.Indented));
            }

            catch (Exception ex)
            {
                if (epicprank == 4)
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
