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

namespace donttapNewDesign.Pages.Frenzy
{
    /// <summary>
    /// Interakční logika pro FrenzyMainPage.xaml
    /// </summary>
    public partial class FrenzyMainPage : Page
    {
        private readonly MainWindow _mainwindow;
        public FrenzyMainPage(MainWindow mw)
        {
            _mainwindow = mw;
            InitializeComponent();
        }
        int x;
        bool custom;
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            int[] settings = Classes.LoadSettings.Load();
            //int lastscore = Classes.LoadLastScore.Load(1);
            TextBlockBoardSize.Text = "Board size: " + settings[0];
            TextBlockBoxSize.Text = "Box size: " + settings[1];
            TextBlockSpacing.Text = "Spacing: " + settings[2];
            //TextBlockLastScore.Text = "Last score: " + lastscore;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            if (custom)
            {
                try
                {
                    x = Convert.ToInt32(TextBoxCustom.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Amount of clicks can be only numbers!", "Value ERROR");
                }
            }
            if (x <= 0)
            {
                MessageBox.Show("Amount of clicks cannot be 0 or less!", "Value ERROR");
            }
            else
            {
                Classes.CreateFrenzySettings.Create(x);
                _mainwindow.ChangeContent(5);
            }
            
        }

        private void ButtonLeaderBoard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void CheckBox30_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox60.IsChecked = false;
            CheckBox90.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            x = 30;

        }

        private void CheckBox60_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox90.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            x = 60;
        }

        private void CheckBox90_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox60.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            x = 90;        
        }

        private void CheckBoxCustom_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox60.IsChecked = false;
            CheckBox90.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Visible;
        }
    }
}
