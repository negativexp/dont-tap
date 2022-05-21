﻿using System;
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Classes.CreateSettings.Create();

            var data = JsonConvert.DeserializeObject<Models.Settings>(File.ReadAllText("settings.json"));
            TextBlockBoardSize.Text = "Board size: " + data.Boardsize.ToString();
            TextBlockBoxSize.Text = "Box size: " + data.Boxsize.ToString();
            TextBlockSpacing.Text = "Spacing: " + data.Spacing.ToString();
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _mainwindow.DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.Close();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.WindowState = WindowState.Minimized;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            _mainwindow.ChangeContent(0);
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            Classes.CreateSettings.Create();

        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            ButtonInfo.Content = "Me too...";
        }
    }
}
