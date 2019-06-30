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
        public MediaPlayer beep = new MediaPlayer();

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
            beep.Open(new Uri(@"D:\Practic\Practic\Resources\boop.mp3", UriKind.Absolute));
            beep.Play();
        }

  
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
           
          GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
            this.Close();
           
            beep.Open(new Uri(@"D:\Practic\Practic\Resources\boop.mp3", UriKind.Absolute));
            beep.Play();
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        { 
        }
    }
}
