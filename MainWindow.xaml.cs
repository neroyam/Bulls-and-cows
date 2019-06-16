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

namespace Practic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainMenu.Close();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

  
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
           
          GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            this.Close();
        }

    }
}
