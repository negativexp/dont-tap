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

namespace donttap.Viewmodels.Endurence.Game
{
    /// <summary>
    /// Interakční logika pro Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        private readonly MainWindow _mainWindow;
        public Game(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        static Label[] labels;

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GameStart(sender);
        }

        private int[] GetSettingsData()
        {
            var data = File.ReadAllText("data/settings.json");
            Models.Settings settings = JsonConvert.DeserializeObject<Models.Settings>(data);
            int[] values = { settings.time, settings.boardSize, settings.boxSize, settings.spacing, settings.amountOfStartingBoxes };
            return values;
        }

        private void GameStart(object sender)
        {
            int[] values = GetSettingsData();
            int time = values[0];
            int boardSize = values[1];
            int boxSize = values[2];
            int spacing = values[3];
            int amountOfStartingBoxes = values[4];

            MessageBox.Show(string.Format("time: {0} \n" +
                                          "board size: {1} \n" +
                                          "box size: {2} \n" +
                                          "spacing: {3} \n" +
                                          "aosb: {4}", values[0], values[1], values[2], values[3], values[4]));

            AdjustSize(boardSize, boxSize, spacing);
            CreateDefinitions(boardSize);
            AddLabels(boardSize, boxSize);
        }

        private void AddLabels(int boardSize, int boxSize)
        {
            labels = new Label[boardSize * boardSize];
            int index = -1;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    index++;
                    labels[index] = GenerateLabel(boxSize);

                    labels[index].Tag = index;
                    labels[index].SetValue(Grid.RowProperty, i);
                    labels[index].SetValue(Grid.ColumnProperty, j);
                    mainGrid.Children.Add(labels[index]);
                }
            }
        }

        private Label GenerateLabel(int boxSize)
        {
            Label label = new Label();
            label.MouseDown += Label_MouseDown;
            label.Background = new SolidColorBrush(Colors.White);
            label.Width = boxSize;
            label.Height = boxSize;
            return label;
        }

        private void CreateDefinitions(int boardSize)
        {
            for (int i = 0; i < boardSize; i++)
            {
                RowDefinition row = new RowDefinition();
                mainGrid.RowDefinitions.Add(row);
            }
            for (int i = 0; i < boardSize; i++)
            {
                ColumnDefinition column = new ColumnDefinition();
                mainGrid.ColumnDefinitions.Add(column);
            }
        }

        private void AdjustSize(int boardSize, int boxSize, int spacing)
        {
            mainGrid.Width = boxSize * boardSize + spacing;
            mainGrid.Height = boxSize * boardSize + spacing;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show((sender as Label).Tag.ToString());
        }
    }
}
