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

namespace donttap.Viewmodels.GameOver
{
    /// <summary>
    /// Interakční logika pro GameOver.xaml
    /// </summary>
    public partial class GameOver : Page
    {
        private readonly MainWindow _mainWindow;
        static int GameMode;
        static int Points;
        public GameOver(MainWindow mainWindow, int points, int gamemode)
        {
            InitializeComponent();

            GameMode = gamemode;
            Points = points;

            _mainWindow = mainWindow;
            TextBlockPoints.Text = "Points: " + points.ToString();
        }

        private void ButtonContinue_Click(object sender, RoutedEventArgs e)
        {
            //create json
            Classes.CreateJson.CreateScore(Points, GameMode, TextBoxName.Text);


            _mainWindow.FramePage.Content = new Viewmodels.Endurence.Settings.Settings(_mainWindow);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _mainWindow.IsEnabled = true;
        }
    }
}
