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

namespace testing
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static int size = 50;
        static int boardsize = 4;
        static int amountOfStartingBoxes = 3;
        static int spacing = 5;
        static Label[] labels = new Label[boardsize*boardsize];
        static int[] inUse = new int[amountOfStartingBoxes];
        static bool[] clickable = new bool[boardsize*boardsize];

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Color[] colors;

            mainGrid.Width = size * boardsize + spacing;
            mainGrid.Height = size * boardsize + spacing;
            this.Width = size * boardsize + 100;
            this.Height = size * boardsize + 250;

            for(int i = 0; i < boardsize; i++)
            {
                ColumnDefinition gridCol = new ColumnDefinition();
                mainGrid.ColumnDefinitions.Add(gridCol);
            }

            for (int i = 0; i < boardsize; i++)
            {
                RowDefinition gridRow = new RowDefinition();
                mainGrid.RowDefinitions.Add(gridRow);
            }

            int index = -1;

            for (int i = 0; i < boardsize; i++)
            {
                for (int j = 0; j < boardsize; j++)
                {
                    index++;
                    labels[index] = GenerateLabel();

                    labels[index].Tag = index;
                    labels[index].MouseDown += Label_MouseDown;
                    labels[index].SetValue(Grid.RowProperty, i);
                    labels[index].SetValue(Grid.ColumnProperty, j);
                    mainGrid.Children.Add(labels[index]);
                }
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!clickable[Convert.ToInt32((sender as Label).Tag)])
                MessageBox.Show("spatne mrdko");
            else
            {

                Random rdm = new Random();

                int clicked = Convert.ToInt32((sender as Label).Tag);
                clickable[clicked] = false;
                ChangeColorToNotClickable((sender as Label));

                int index = Array.IndexOf(inUse, clicked);

                int number = rdm.Next(0, boardsize * boardsize);

                while(inUse.Contains(number))
                    number = rdm.Next(0, boardsize * boardsize);

                inUse[index] = number;
                clickable[number] = true;
                ChangeColorToClickable(labels[number]);
            }
        }

        private void ChangeColorToClickable(Label label)
        {
            label.Background = Brushes.Black;
        }
        private void ChangeColorToNotClickable(Label label)
        {
            label.Background = Brushes.Gray;
        }
        private Label GenerateLabel()
        {
            Label label = new Label();
            label.Background = Brushes.Gray;
            label.Width = size;
            label.Height = size;
            label.VerticalAlignment = VerticalAlignment.Center;
            label.HorizontalAlignment = HorizontalAlignment.Center;
            label.BorderBrush = Brushes.Black;
            label.BorderThickness = new Thickness(0, 0, 0, 0);
            return label;
        }
        private void GameStart()
        {
            //reset
            foreach(Label label in labels)
                label.Background = Brushes.Gray;

            //start
            Random rdm = new Random();

            for (int i = 0; i < inUse.Length; i++)
            {
                int number = rdm.Next(0, boardsize*boardsize);

                while (inUse.Contains(number))
                    number = rdm.Next(0, boardsize*boardsize);

                inUse[i] = number;
                clickable[number] = true;
                ChangeColorToClickable(labels[number]);
            }
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            GameStart();
        }
    }
}
