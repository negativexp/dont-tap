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

                if (time <= 0)
                {
                    MessageBox.Show("Sure, 0 seconds, makes sense", "are you retarted");
                    if (amountOfStartingBoxes > boardSize*boardSize)
                    {
                        MessageBox.Show(String.Format("Dude, how do you want more starting boxes ({0}) when there are less boxes? ({1})", amountOfStartingBoxes, boardSize*boardSize), "3rd grade");
                        ableToStart = false;
                    }
                }
                else ableToStart = true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Please make sure you typed in correct values! (only numbers!)");
            }
            if (ableToStart)
            {
                //json
                Models.Settings settings = new Models.Settings();

                settings.time = time;
                settings.boardSize = boardSize;
                settings.boxSize = boxSize;
                settings.spacing = spacing;
                settings.amountOfStartingBoxes = amountOfStartingBoxes;

                _mainwindow.FramePage.Content = new Viewmodels.Endurence.Game.Game();

            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.FramePage.Content = null;
            _mainwindow.GridAll.Visibility = Visibility.Visible;
        }
    }
}
