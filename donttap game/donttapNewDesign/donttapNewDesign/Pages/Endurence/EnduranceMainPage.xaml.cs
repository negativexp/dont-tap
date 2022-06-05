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

namespace donttapNewDesign.Pages.Endurence
{
    /// <summary>
    /// Interakční logika pro EndurenceMainPage.xaml
    /// </summary>
    public partial class EndurenceMainPage : Page
    {
        private readonly MainWindow _mainwindow;
        int clicks;
        bool custom;
        int boardsize;
        int boxsize;
        int spacing;
        public EndurenceMainPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        private async Task LoadData()
        {
            int[] settigns = await Task.Run(() => Classes.LoadSettings.Load());
            TextBlockBoardSize.Text = "Board size: " + settigns[0];
            TextBlockBoxSize.Text = "Box size: " + settigns[1];
            TextBlockSpacing.Text = "Spacing: " + settigns[2];
            boardsize = settigns[0];
            boxsize = settigns[1];
            spacing = settigns[2];

            int lastscore = await Task.Run(() => Classes.LoadLastScore.Load(0)); ;
            TextBlockLastScore.Text = "Last score: " + lastscore.ToString();

            int endurancesettings = await Task.Run(() => Classes.LoadEnduranceSettings.Load());
            if (endurancesettings == 30)
                CheckBox30Clicks.IsChecked = true;
            else if (endurancesettings == 40)
                CheckBox40Clicks.IsChecked = true;
            else if (endurancesettings == 50)
                CheckBox50Clicks.IsChecked = true;
            else
            {
                CheckBoxCustom.IsChecked = true;
                TextBoxCustom.Text = endurancesettings.ToString();
            }
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if(custom)
            {
                try
                {
                    clicks = Convert.ToInt32(TextBoxCustom.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Amount of clicks can be only numbers!", "Value ERROR");
                }
            }
            if (clicks <= 0)
            {
                MessageBox.Show("Amount of clicks cannot be 0 or less!", "Value ERROR");
            }
            else
            {
                Classes.CreateEndurenceSettings.Create(clicks);
                _mainwindow.ChangeContent(6);
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonLeaderBoard_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(7);
        }

        private void CheckBox30Clicks_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox40Clicks.IsChecked = false;
            CheckBox50Clicks.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            clicks = 30;
        }

        private void CheckBox40Clicks_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30Clicks.IsChecked = false;
            CheckBox50Clicks.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            clicks = 40;
        }

        private void CheckBox50Clicks_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30Clicks.IsChecked = false;
            CheckBox40Clicks.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            clicks = 50;
        }

        private void CheckBoxCustom_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30Clicks.IsChecked = false;
            CheckBox40Clicks.IsChecked = false;
            CheckBox50Clicks.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Visible;
            custom = true;
        }
    }
}
