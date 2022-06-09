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
        int time;
        bool custom;
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

            int lastscore = await Task.Run(() => Classes.LoadLastScore.Load(1));
            TextBlockLastScore.Text = "Last score: " + lastscore.ToString();

            int frenzysettings = await Task.Run(() => Classes.LoadFrenzySettings.Load());
            if (frenzysettings == 30)
                CheckBox30.IsChecked = true;
            else if (frenzysettings == 60)
                CheckBox60.IsChecked = true;
            else if (frenzysettings == 90)
                CheckBox90.IsChecked = true;
            else
            {
                CheckBoxCustom.IsChecked = true;
                TextBoxCustom.Text = frenzysettings.ToString();
            }
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
                    time = Convert.ToInt32(TextBoxCustom.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Amount of clicks can be only numbers!", "Value ERROR");
                }
            }
            if (time <= 0)
            {
                MessageBox.Show("Amount of clicks cannot be 0 or less!", "Value ERROR");
            }
            else
            {
                Classes.CreateData.Create();
                Classes.CreateFrenzySettings.Create(time);
                _mainwindow.ChangeContent(5);
            }
            
        }

        private void ButtonLeaderBoard_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(8);
        }

        private void CheckBox30_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox60.IsChecked = false;
            CheckBox90.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            time = 30;

        }

        private void CheckBox60_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox90.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            time = 60;
        }

        private void CheckBox90_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox60.IsChecked = false;
            CheckBoxCustom.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Hidden;
            custom = false;
            time = 90;        
        }

        private void CheckBoxCustom_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox30.IsChecked = false;
            CheckBox60.IsChecked = false;
            CheckBox90.IsChecked = false;
            TextBoxCustom.Visibility = Visibility.Visible;
            custom = true;
        }
    }
}
