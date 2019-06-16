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
using System.Windows.Shapes;

namespace Practic
{
    
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
      
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }
        public List<int> mainCode = new List<int>();
        public List<int> userCode = new List<int>();

        public Board board = new Board();
    

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Generation generation = new Generation();
            mainCode = generation.SetCode();
                 
        }

        private void Butt1_Click(object sender, RoutedEventArgs e)
        {
            if (Butt00.IsEnabled)
            {
                if ( Butt00.Content.ToString() == "_______") Butt00.Content = (sender as Button).Content.ToString();
                else if (Butt10.Content.ToString() == "_______") Butt10.Content = (sender as Button).Content.ToString();
                else if (Butt20.Content.ToString() == "_______") Butt20.Content = (sender as Button).Content.ToString();
                else if (Butt30.Content.ToString() == "_______")
                {
                    Butt30.Content = (sender as Button).Content.ToString();
                    Button0.IsEnabled = true;
                }
            }

            if (Butt01.IsEnabled)
            {
                if (Butt01.Content.ToString() == "_______") Butt01.Content = (sender as Button).Content.ToString();
                else if (Butt11.Content.ToString() == "_______") Butt11.Content = (sender as Button).Content.ToString();
                else if (Butt21.Content.ToString() == "_______") Butt21.Content = (sender as Button).Content.ToString();
                else if (Butt31.Content.ToString() == "_______")
                {
                    Butt31.Content = (sender as Button).Content.ToString();
                    Button1.IsEnabled = true;
                }
            }

            if (Butt02.IsEnabled)
            {
                if (Butt02.Content.ToString() == "_______") Butt02.Content = (sender as Button).Content.ToString();
                else if (Butt12.Content.ToString() == "_______") Butt12.Content = (sender as Button).Content.ToString();
                else if (Butt22.Content.ToString() == "_______") Butt22.Content = (sender as Button).Content.ToString();
                else if (Butt32.Content.ToString() == "_______")
                {
                    Butt32.Content = (sender as Button).Content.ToString();
                    Button2.IsEnabled = true;
                }
            }

            if (Butt03.IsEnabled)
            {
                if (Butt03.Content.ToString() == "_______") Butt03.Content = (sender as Button).Content.ToString();
                else if (Butt13.Content.ToString() == "_______") Butt13.Content = (sender as Button).Content.ToString();
                else if (Butt23.Content.ToString() == "_______") Butt23.Content = (sender as Button).Content.ToString();
                else if (Butt33.Content.ToString() == "_______")
                {
                    Butt33.Content = (sender as Button).Content.ToString();
                    Button3.IsEnabled = true;
                }
            }

            if (Butt04.IsEnabled)
            {
                if (Butt04.Content.ToString() == "_______") Butt04.Content = (sender as Button).Content.ToString();
                else if (Butt14.Content.ToString() == "_______") Butt14.Content = (sender as Button).Content.ToString();
                else if (Butt24.Content.ToString() == "_______") Butt24.Content = (sender as Button).Content.ToString();
                else if (Butt34.Content.ToString() == "_______")
                {
                    Butt34.Content = (sender as Button).Content.ToString();
                    Button4.IsEnabled = true;
                }
            }
            if (Butt05.IsEnabled)
            {
                if (Butt05.Content.ToString() == "_______") Butt05.Content = (sender as Button).Content.ToString();
                else if (Butt15.Content.ToString() == "_______") Butt15.Content = (sender as Button).Content.ToString();
                else if (Butt25.Content.ToString() == "_______") Butt25.Content = (sender as Button).Content.ToString();
                else if (Butt35.Content.ToString() == "_______")
                {
                    Butt35.Content = (sender as Button).Content.ToString();
                    Button5.IsEnabled = true;
                }
            }
            if (Butt06.IsEnabled)
            {
                if (Butt06.Content.ToString() == "_______") Butt06.Content = (sender as Button).Content.ToString();
                else if (Butt16.Content.ToString() == "_______") Butt16.Content = (sender as Button).Content.ToString();
                else if (Butt26.Content.ToString() == "_______") Butt26.Content = (sender as Button).Content.ToString();
                else if (Butt36.Content.ToString() == "_______")
                {
                    Butt36.Content = (sender as Button).Content.ToString();
                    Button6.IsEnabled = true;
                }
            }
            if (Butt07.IsEnabled)
            {
                if (Butt07.Content.ToString() == "_______") Butt07.Content = (sender as Button).Content.ToString();
                else if (Butt17.Content.ToString() == "_______") Butt17.Content = (sender as Button).Content.ToString();
                else if (Butt27.Content.ToString() == "_______") Butt27.Content = (sender as Button).Content.ToString();
                else if (Butt37.Content.ToString() == "_______")
                {
                    Butt37.Content = (sender as Button).Content.ToString();
                    Button7.IsEnabled = true;
                }
            }
            if (Butt08.IsEnabled)
            {
                if (Butt08.Content.ToString() == "_______") Butt08.Content = (sender as Button).Content.ToString();
                else if (Butt18.Content.ToString() == "_______") Butt18.Content = (sender as Button).Content.ToString();
                else if (Butt28.Content.ToString() == "_______") Butt28.Content = (sender as Button).Content.ToString();
                else if (Butt38.Content.ToString() == "_______")
                {
                    Butt38.Content = (sender as Button).Content.ToString();
                    Button8.IsEnabled = true;
                }
            }
            if (Butt09.IsEnabled)
            {
                if (Butt09.Content.ToString() == "_______") Butt09.Content = (sender as Button).Content.ToString();
                else if (Butt19.Content.ToString() == "_______") Butt19.Content = (sender as Button).Content.ToString();
                else if (Butt29.Content.ToString() == "_______") Butt29.Content = (sender as Button).Content.ToString();
                else if (Butt39.Content.ToString() == "_______")
                {
                    Butt39.Content = (sender as Button).Content.ToString();
                    Button9.IsEnabled = true;
                }
            }
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            
            if (Butt00.IsEnabled)
            {
                
                userCode.Add(int.Parse(Butt00.Content.ToString()));
                userCode.Add(int.Parse(Butt10.Content.ToString()));
                userCode.Add(int.Parse(Butt20.Content.ToString()));
                userCode.Add(int.Parse(Butt30.Content.ToString()));

                board.Check(userCode, mainCode);
                Button0.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {
                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                   else this.Close(); 
                }
                else board.Zero();
                


                Butt00.IsEnabled = false;
                Butt10.IsEnabled = false;
                Butt20.IsEnabled = false;
                Butt30.IsEnabled = false;
                Button0.IsEnabled = false;

                Butt01.IsEnabled = true;
                Butt11.IsEnabled = true;
                Butt21.IsEnabled = true;
                Butt31.IsEnabled = true;
                Button1.Opacity= 0.9;

            }
            else if (Butt01.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt01.Content.ToString()));
                userCode.Add(int.Parse(Butt11.Content.ToString()));
                userCode.Add(int.Parse(Butt21.Content.ToString()));
                userCode.Add(int.Parse(Butt31.Content.ToString()));

                board.Check(userCode, mainCode);
                Button1.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt01.IsEnabled = false;
                Butt11.IsEnabled = false;
                Butt21.IsEnabled = false;
                Butt31.IsEnabled = false;
                Button1.IsEnabled = false;

                Butt02.IsEnabled = true;
                Butt12.IsEnabled = true;
                Butt22.IsEnabled = true;
                Butt32.IsEnabled = true;
                Button2.Opacity = 0.9;

            }
            else if(Butt02.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt02.Content.ToString()));
                userCode.Add(int.Parse(Butt12.Content.ToString()));
                userCode.Add(int.Parse(Butt22.Content.ToString()));
                userCode.Add(int.Parse(Butt32.Content.ToString()));

                board.Check(userCode, mainCode);
                Button2.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt02.IsEnabled = false;
                Butt12.IsEnabled = false;
                Butt22.IsEnabled = false;
                Butt32.IsEnabled = false;
                Button2.IsEnabled = false;

                Butt03.IsEnabled = true;
                Butt13.IsEnabled = true;
                Butt23.IsEnabled = true;
                Butt33.IsEnabled = true;
                Button3.Opacity = 0.9;

            }
            else if (Butt03.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt03.Content.ToString()));
                userCode.Add(int.Parse(Butt13.Content.ToString()));
                userCode.Add(int.Parse(Butt23.Content.ToString()));
                userCode.Add(int.Parse(Butt33.Content.ToString()));

                board.Check(userCode, mainCode);
                Button3.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt03.IsEnabled = false;
                Butt13.IsEnabled = false;
                Butt23.IsEnabled = false;
                Butt33.IsEnabled = false;
                Button3.IsEnabled = false;

                Butt04.IsEnabled = true;
                Butt14.IsEnabled = true;
                Butt24.IsEnabled = true;
                Butt34.IsEnabled = true;
                Button4.Opacity = 0.9;

            }
           else if (Butt04.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt04.Content.ToString()));
                userCode.Add(int.Parse(Butt14.Content.ToString()));
                userCode.Add(int.Parse(Butt24.Content.ToString()));
                userCode.Add(int.Parse(Butt34.Content.ToString()));

                board.Check(userCode, mainCode);
                Button4.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt04.IsEnabled = false;
                Butt14.IsEnabled = false;
                Butt24.IsEnabled = false;
                Butt34.IsEnabled = false;
                Button4.IsEnabled = false;

                Butt05.IsEnabled = true;
                Butt15.IsEnabled = true;
                Butt25.IsEnabled = true;
                Butt35.IsEnabled = true;
                Button5.Opacity = 0.9;

            }
            else if (Butt05.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt05.Content.ToString()));
                userCode.Add(int.Parse(Butt15.Content.ToString()));
                userCode.Add(int.Parse(Butt25.Content.ToString()));
                userCode.Add(int.Parse(Butt35.Content.ToString()));

                board.Check(userCode, mainCode);
                Button5.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt05.IsEnabled = false;
                Butt15.IsEnabled = false;
                Butt25.IsEnabled = false;
                Butt35.IsEnabled = false;
                Button5.IsEnabled = false;

                Butt06.IsEnabled = true;
                Butt16.IsEnabled = true;
                Butt26.IsEnabled = true;
                Butt36.IsEnabled = true;
                Button6.Opacity = 0.9;

            }
            else if (Butt06.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt06.Content.ToString()));
                userCode.Add(int.Parse(Butt16.Content.ToString()));
                userCode.Add(int.Parse(Butt26.Content.ToString()));
                userCode.Add(int.Parse(Butt36.Content.ToString()));

                board.Check(userCode, mainCode);
                Button6.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {
                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt06.IsEnabled = false;
                Butt16.IsEnabled = false;
                Butt26.IsEnabled = false;
                Butt36.IsEnabled = false;
                Button6.IsEnabled = false;

                Butt07.IsEnabled = true;
                Butt17.IsEnabled = true;
                Butt27.IsEnabled = true;
                Butt37.IsEnabled = true;
                Button7.Opacity = 0.9;

            }
            else if (Butt07.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt07.Content.ToString()));
                userCode.Add(int.Parse(Butt17.Content.ToString()));
                userCode.Add(int.Parse(Butt27.Content.ToString()));
                userCode.Add(int.Parse(Butt37.Content.ToString()));

                board.Check(userCode, mainCode);
                Button7.Content = board.Res[0] + " " + board.Res[1];
                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else board.Zero();


                Butt07.IsEnabled = false;
                Butt17.IsEnabled = false;
                Butt27.IsEnabled = false;
                Butt37.IsEnabled = false;
                Button7.IsEnabled = false;

                Butt08.IsEnabled = true;
                Butt18.IsEnabled = true;
                Butt28.IsEnabled = true;
                Butt38.IsEnabled = true;
                Button8.Opacity = 0.9;

            }
            else if (Butt08.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt08.Content.ToString()));
                userCode.Add(int.Parse(Butt18.Content.ToString()));
                userCode.Add(int.Parse(Butt28.Content.ToString()));
                userCode.Add(int.Parse(Butt38.Content.ToString()));

                board.Check(userCode, mainCode);
                Button8.Content = board.Res[0] + " " + board.Res[1];

                if (board.status == GameStat.Win)
                {

                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else   board.Zero();


                Butt08.IsEnabled = false;
                Butt18.IsEnabled = false;
                Butt28.IsEnabled = false;
                Butt38.IsEnabled = false;
                Button8.IsEnabled = false;

                Butt09.IsEnabled = true;
                Butt19.IsEnabled = true;
                Butt29.IsEnabled = true;
                Butt39.IsEnabled = true;
                Button9.Opacity = 0.9;

            }
            else if (Butt09.IsEnabled)
            {
                userCode.Clear();

                userCode.Add(int.Parse(Butt09.Content.ToString()));
                userCode.Add(int.Parse(Butt19.Content.ToString()));
                userCode.Add(int.Parse(Butt29.Content.ToString()));
                userCode.Add(int.Parse(Butt39.Content.ToString()));

                board.Check(userCode, mainCode);
                Button9.Content = board.Res[0] + " " + board.Res[1];

                if (board.status == GameStat.Win)
                {
                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Победа", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Хотите сыграть еще раз?", "Поражение", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes) { GameWindow gameWindow = new GameWindow(); gameWindow.Show(); this.Close(); this.mainWindow.Close(); }
                    else this.Close();
                }


            }

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }
        MainWindow mainWindow = new MainWindow();

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
          //  MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CodeButtShow_Click(object sender, RoutedEventArgs e)
        {
            CodeButt0.Content = mainCode[0].ToString();
            CodeButt1.Content = mainCode[1].ToString();
            CodeButt2.Content = mainCode[2].ToString();
            CodeButt3.Content = mainCode[3].ToString();

            //LoseWindow loseWindow = new LoseWindow();
            //loseWindow.Show();
            //this.Close();
        }

        private void ExitButtonFin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
