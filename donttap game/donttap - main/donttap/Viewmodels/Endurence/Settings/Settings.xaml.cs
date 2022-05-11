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

namespace donttap.Viewmodels.Endurence.Settings
{
    /// <summary>
    /// Interakční logika pro Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        private readonly MainWindow _mainwindow;
        public Settings(MainWindow mainwindow)
        {
            InitializeComponent();
            _mainwindow = mainwindow;
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            bool ableToStart = false;
            int boardSize = 0;
            int boxSize = 0;
            int time = 0;
            int spacing = 0;
            int amountOfStartingBoxes = 0;

            try
            {
                boardSize = Convert.ToInt32(TextBoxBoardSize.Text);
                boxSize = Convert.ToInt32(TextBoxBoxSize.Text);
                time = Convert.ToInt32(TextBoxTime.Text);
                spacing = Convert.ToInt32(TextBoxSpacing.Text);
                amountOfStartingBoxes = Convert.ToInt32(TextBoxAmountOfStartingBoxes.Text);

                ableToStart = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Please make sure you typed in correct values! (only numbers!)");
            }
            if (ableToStart)
            {
                //json
                CreateSettings(time, boardSize, boxSize,
                                            spacing, amountOfStartingBoxes);

                _mainwindow.FramePage.Content = new Viewmodels.Endurence.Game.Game(_mainwindow);
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.FramePage.Content = null;
            _mainwindow.GridAll.Visibility = Visibility.Visible;
        }

        private void CreateSettings(int time, int boardSize, int boxSize, int spacing,
                                         int amountOfStartingBoxes)
        {
            Classes.CreateSettingsJson.CreateFolder();
            Classes.CreateSettingsJson.Create(time, boardSize, boxSize,
                                        spacing, amountOfStartingBoxes);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //checks if settings.json exist to paste settings

            if (File.Exists("data/settings.json"))
            {
                var data = File.ReadAllText("data/settings.json");
                Models.Settings settings = JsonConvert.DeserializeObject<Models.Settings>(data);
                TextBoxTime.Text = settings.time.ToString();
                TextBoxBoardSize.Text = settings.boardSize.ToString();
                TextBoxBoxSize.Text = settings.boxSize.ToString();
                TextBoxSpacing.Text = settings.spacing.ToString();
                TextBoxAmountOfStartingBoxes.Text = settings.amountOfStartingBoxes.ToString();
            }
        }
    }
}
