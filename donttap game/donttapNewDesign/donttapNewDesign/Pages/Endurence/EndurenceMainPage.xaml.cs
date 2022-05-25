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
        public EndurenceMainPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Classes.CreateSettings.Create();

            var data = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));
            TextBlockBoardSize.Text = "Board size: " + data.Boardsize.ToString();
            TextBlockBoxSize.Text = "Box size: " + data.Boxsize.ToString();
            TextBlockSpacing.Text = "Spacing: " + data.Spacing.ToString();
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
                    clicks = Convert.ToInt32(TextBoxCustomClicks.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Amount of clicks can be only numbers!");
                }
            }
            if (clicks <= 0)
            {
                MessageBox.Show("Amount of clicks cannot be 0 or less!", "Value ERROR");
            }
            else
            {
                Classes.CreateSettings.Create();
                Classes.CreateEndurenceSettings.Create(clicks);
                _mainwindow.ChangeContent(6);
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void Button30_Click(object sender, RoutedEventArgs e)
        {
            if (clicks != 30)
            {
                clicks = 30;
                Button30.Background = new SolidColorBrush(Colors.Green);
                Button40.Background = new SolidColorBrush(Colors.Transparent);
                Button50.Background = new SolidColorBrush(Colors.Transparent);
                ButtonCustom.Background = new SolidColorBrush(Colors.Transparent);
                TextBoxCustomClicks.Visibility = Visibility.Hidden;
                custom = false;
            }
        }

        private void Button40_Click(object sender, RoutedEventArgs e)
        {
            if (clicks != 40)
            {
                clicks = 40;
                Button30.Background = new SolidColorBrush(Colors.Transparent);
                Button40.Background = new SolidColorBrush(Colors.Green);
                Button50.Background = new SolidColorBrush(Colors.Transparent);
                ButtonCustom.Background = new SolidColorBrush(Colors.Transparent);
                TextBoxCustomClicks.Visibility = Visibility.Hidden;
                custom = false;
            }
        }

        private void Button50_Click(object sender, RoutedEventArgs e)
        {
            if (clicks != 50)
            {
                clicks = 50;
                Button30.Background = new SolidColorBrush(Colors.Transparent);
                Button40.Background = new SolidColorBrush(Colors.Transparent);
                Button50.Background = new SolidColorBrush(Colors.Green);
                ButtonCustom.Background = new SolidColorBrush(Colors.Transparent);
                TextBoxCustomClicks.Visibility = Visibility.Hidden;
                custom = false;
            }
        }

        private void ButtonCustom_Click(object sender, RoutedEventArgs e)
        {
            if (clicks != 30 || clicks != 40 || clicks != 50)
            {
                Button30.Background = new SolidColorBrush(Colors.Transparent);
                Button40.Background = new SolidColorBrush(Colors.Transparent);
                Button50.Background = new SolidColorBrush(Colors.Transparent);
                ButtonCustom.Background = new SolidColorBrush(Colors.Green);
                TextBoxCustomClicks.Visibility = Visibility.Visible;
                custom = true;
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonLeaderBoard_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(7);
        }
    }
}
