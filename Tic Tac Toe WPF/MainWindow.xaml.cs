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

namespace Tic_Tac_Toe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Artificialintelligence = false;
        int counter = 1;
        string move;
        int multiplayerx = 0;
        int multiplayero = 0;
        int userwin = 0;
        int aiwin = 0;
        int drawsvsai = 0;
        int drawsvsuser = 0;
        public MainWindow()
        {
            InitializeComponent();
            gamegridhide();
            tblockhide();
          
        }
        public void tblockhide()
        {
            mytblock.Height = 0;
            mytblock.Width = 0;
        }
        public void myAILogic()
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (Artificialintelligence && counter<9)
            {
                switch (counter)
                {
                    case 2:
                        if (btn5.Content.ToString() == "")
                        {
                            btn5.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else
                        {
                            var rand = new Random();
                            int play = rand.Next(0, 5);
                            if (play == 1)
                                btn1.Content = move;
                            else if (play == 2)
                                btn3.Content = move;
                            else if (play == 3)
                                btn7.Content = move;
                            else
                                btn9.Content = move;
                            counter++;
                            label();
                            break;
                        }
                    case 4:
                        if (btn5.Content.ToString() == "X" && btn9.Content.ToString() == "X" &&
                            btn1.Content.ToString() == "" || btn4.Content.ToString() == "X" && btn7.Content.ToString() == "X"
                            && btn1.Content.ToString() == "" || btn2.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn1.Content.ToString() == "")
                        {
                            btn1.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn1.Content.ToString() == "X" && btn3.Content.ToString() == "X" && btn2.Content.ToString() == ""
                            || btn5.Content.ToString() == "X" && btn8.Content.ToString() == "X" && btn2.Content.ToString() == "")
                        {
                            btn2.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn7.Content.ToString() == "X" &&
                            btn3.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn2.Content.ToString() == "X"
                            && btn3.Content.ToString() == "" || btn6.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn3.Content.ToString() == "")
                        {
                            btn3.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn6.Content.ToString() == "X" && btn4.Content.ToString() == ""
                            || btn1.Content.ToString() == "X" && btn7.Content.ToString() == "X" && btn4.Content.ToString() == "")
                        {
                            btn4.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn5.Content.ToString() == "X" && btn6.Content.ToString() == ""
                            || btn3.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn6.Content.ToString() == "")
                        {
                            btn6.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn1.Content.ToString() == "X" &&
                            btn7.Content.ToString() == "" || btn5.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn7.Content.ToString() == "" || btn8.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn7.Content.ToString() == "")
                        {
                            btn7.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn3.Content.ToString() == "X" && btn6.Content.ToString() == "X" &&
                            btn9.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn5.Content.ToString() == "X"
                            && btn9.Content.ToString() == "" || btn7.Content.ToString() == "X" && btn8.Content.ToString() == "X"
                            && btn9.Content.ToString() == "")
                        {
                            btn9.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn2.Content.ToString() == "X" && btn8.Content.ToString() == ""
                           || btn7.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn8.Content.ToString() == "")
                        {
                            btn8.Content = move;
                            counter++;
                            label();
                            break;
                        }
                        else
                        {
                            if (btn1.Content.ToString() == "") btn1.Content = move;
                            else if (btn2.Content.ToString() == "") btn2.Content = move;
                            else if (btn3.Content.ToString() == "") btn3.Content = move;
                            else if (btn4.Content.ToString() == "") btn4.Content = move;
                            else if (btn5.Content.ToString() == "") btn5.Content = move;
                            else if (btn6.Content.ToString() == "") btn6.Content = move;
                            else if (btn7.Content.ToString() == "") btn7.Content = move;
                            else if (btn8.Content.ToString() == "") btn8.Content = move;
                            else btn9.Content = move;
                            counter++;
                            label();
                            break;
                        }
                    case 6:
                        if (btn5.Content.ToString() == "O" && btn9.Content.ToString() == "O" &&
                            btn1.Content.ToString() == "" || btn4.Content.ToString() == "O" && btn7.Content.ToString() == "O"
                            && btn1.Content.ToString() == "" || btn2.Content.ToString() == "O" && btn3.Content.ToString() == "O"
                            && btn1.Content.ToString() == "")
                        {
                            btn1.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn1.Content.ToString() == "O" && btn3.Content.ToString() == "O" && btn2.Content.ToString() == ""
                            || btn5.Content.ToString() == "O" && btn8.Content.ToString() == "O" && btn2.Content.ToString() == "")
                        {
                            btn2.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn7.Content.ToString() == "O" &&
                            btn3.Content.ToString() == "" || btn1.Content.ToString() == "O" && btn2.Content.ToString() == "O"
                            && btn3.Content.ToString() == "" || btn6.Content.ToString() == "O" && btn9.Content.ToString() == "O"
                            && btn3.Content.ToString() == "")
                        {
                            btn3.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn6.Content.ToString() == "O" && btn4.Content.ToString() == ""
                            || btn1.Content.ToString() == "O" && btn7.Content.ToString() == "O" && btn4.Content.ToString() == "")
                        {
                            btn4.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "O" && btn5.Content.ToString() == "O" && btn6.Content.ToString() == ""
                            || btn3.Content.ToString() == "O" && btn9.Content.ToString() == "O" && btn6.Content.ToString() == "")
                        {
                            btn6.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "O" && btn1.Content.ToString() == "O" &&
                            btn7.Content.ToString() == "" || btn5.Content.ToString() == "O" && btn3.Content.ToString() == "O"
                            && btn7.Content.ToString() == "" || btn8.Content.ToString() == "O" && btn9.Content.ToString() == "O"
                            && btn7.Content.ToString() == "")
                        {
                            btn7.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn3.Content.ToString() == "O" && btn6.Content.ToString() == "O" &&
                            btn9.Content.ToString() == "" || btn1.Content.ToString() == "O" && btn5.Content.ToString() == "O"
                            && btn9.Content.ToString() == "" || btn7.Content.ToString() == "O" && btn8.Content.ToString() == "O"
                            && btn9.Content.ToString() == "")
                        {
                            btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn2.Content.ToString() == "O" && btn8.Content.ToString() == ""
                           || btn7.Content.ToString() == "O" && btn9.Content.ToString() == "O" && btn8.Content.ToString() == "")
                        {
                            btn8.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn9.Content.ToString() == "X" &&
                            btn1.Content.ToString() == "" || btn4.Content.ToString() == "X" && btn7.Content.ToString() == "X"
                            && btn1.Content.ToString() == "" || btn2.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn1.Content.ToString() == "")
                        {
                            btn1.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn1.Content.ToString() == "X" && btn3.Content.ToString() == "X" && btn2.Content.ToString() == ""
                            || btn5.Content.ToString() == "X" && btn8.Content.ToString() == "X" && btn2.Content.ToString() == "")
                        {
                            btn2.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn7.Content.ToString() == "X" &&
                            btn3.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn2.Content.ToString() == "X"
                            && btn3.Content.ToString() == "" || btn6.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn3.Content.ToString() == "")
                        {
                            btn3.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn6.Content.ToString() == "X" && btn4.Content.ToString() == ""
                            || btn1.Content.ToString() == "X" && btn7.Content.ToString() == "X" && btn4.Content.ToString() == "")
                        {
                            btn4.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn5.Content.ToString() == "X" && btn6.Content.ToString() == ""
                            || btn3.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn6.Content.ToString() == "")
                        {
                            btn6.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn1.Content.ToString() == "X" &&
                            btn7.Content.ToString() == "" || btn5.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn7.Content.ToString() == "" || btn8.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn7.Content.ToString() == "")
                        {
                            btn7.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn3.Content.ToString() == "X" && btn6.Content.ToString() == "X" &&
                            btn9.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn5.Content.ToString() == "X"
                            && btn9.Content.ToString() == "" || btn7.Content.ToString() == "X" && btn8.Content.ToString() == "X"
                            && btn9.Content.ToString() == "")
                        {
                            btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn2.Content.ToString() == "X" && btn8.Content.ToString() == ""
                           || btn7.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn8.Content.ToString() == "")
                        {
                            btn8.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else
                        {
                            if (btn1.Content.ToString() == "") btn1.Content = move;
                            else if (btn2.Content.ToString() == "") btn2.Content = move;
                            else if (btn3.Content.ToString() == "") btn3.Content = move;
                            else if (btn4.Content.ToString() == "") btn4.Content = move;
                            else if (btn5.Content.ToString() == "") btn5.Content = move;
                            else if (btn6.Content.ToString() == "") btn6.Content = move;
                            else if (btn7.Content.ToString() == "") btn7.Content = move;
                            else if (btn8.Content.ToString() == "") btn8.Content = move;
                            else btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                    case 8:
                        if (btn5.Content.ToString() == "O" && btn9.Content.ToString() == "O" &&
                            btn1.Content.ToString() == "" || btn4.Content.ToString() == "O" && btn7.Content.ToString() == "O"
                            && btn1.Content.ToString() == "" || btn2.Content.ToString() == "O" && btn3.Content.ToString() == "O"
                            && btn1.Content.ToString() == "")
                        {
                            btn1.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn1.Content.ToString() == "O" && btn3.Content.ToString() == "O" && btn2.Content.ToString() == ""
                            || btn5.Content.ToString() == "O" && btn8.Content.ToString() == "O" && btn2.Content.ToString() == "")
                        {
                            btn2.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn7.Content.ToString() == "O" &&
                            btn3.Content.ToString() == "" || btn1.Content.ToString() == "O" && btn2.Content.ToString() == "O"
                            && btn3.Content.ToString() == "" || btn6.Content.ToString() == "O" && btn9.Content.ToString() == "O"
                            && btn3.Content.ToString() == "")
                        {
                            btn3.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn6.Content.ToString() == "O" && btn4.Content.ToString() == ""
                            || btn1.Content.ToString() == "O" && btn7.Content.ToString() == "O" && btn4.Content.ToString() == "")
                        {
                            btn4.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "O" && btn5.Content.ToString() == "O" && btn6.Content.ToString() == ""
                            || btn3.Content.ToString() == "O" && btn9.Content.ToString() == "O" && btn6.Content.ToString() == "")
                        {
                            btn6.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "O" && btn1.Content.ToString() == "O" &&
                            btn7.Content.ToString() == "" || btn5.Content.ToString() == "O" && btn3.Content.ToString() == "O"
                            && btn7.Content.ToString() == "" || btn8.Content.ToString() == "O" && btn9.Content.ToString() == "O"
                            && btn7.Content.ToString() == "")
                        {
                            btn7.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn3.Content.ToString() == "O" && btn6.Content.ToString() == "O" &&
                            btn9.Content.ToString() == "" || btn1.Content.ToString() == "O" && btn5.Content.ToString() == "O"
                            && btn9.Content.ToString() == "" || btn7.Content.ToString() == "O" && btn8.Content.ToString() == "O"
                            && btn9.Content.ToString() == "")
                        {
                            btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "O" && btn2.Content.ToString() == "O" && btn8.Content.ToString() == ""
                           || btn7.Content.ToString() == "O" && btn9.Content.ToString() == "O" && btn8.Content.ToString() == "")
                        {
                            btn8.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn9.Content.ToString() == "X" &&
                            btn1.Content.ToString() == "" || btn4.Content.ToString() == "X" && btn7.Content.ToString() == "X"
                            && btn1.Content.ToString() == "" || btn2.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn1.Content.ToString() == "")
                        {
                            btn1.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn1.Content.ToString() == "X" && btn3.Content.ToString() == "X" && btn2.Content.ToString() == ""
                            || btn5.Content.ToString() == "X" && btn8.Content.ToString() == "X" && btn2.Content.ToString() == "")
                        {
                            btn2.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn7.Content.ToString() == "X" &&
                            btn3.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn2.Content.ToString() == "X"
                            && btn3.Content.ToString() == "" || btn6.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn3.Content.ToString() == "")
                        {
                            btn3.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn6.Content.ToString() == "X" && btn4.Content.ToString() == ""
                            || btn1.Content.ToString() == "X" && btn7.Content.ToString() == "X" && btn4.Content.ToString() == "")
                        {
                            btn4.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn5.Content.ToString() == "X" && btn6.Content.ToString() == ""
                            || btn3.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn6.Content.ToString() == "")
                        {
                            btn6.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn4.Content.ToString() == "X" && btn1.Content.ToString() == "X" &&
                            btn7.Content.ToString() == "" || btn5.Content.ToString() == "X" && btn3.Content.ToString() == "X"
                            && btn7.Content.ToString() == "" || btn8.Content.ToString() == "X" && btn9.Content.ToString() == "X"
                            && btn7.Content.ToString() == "")
                        {
                            btn7.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn3.Content.ToString() == "X" && btn6.Content.ToString() == "X" &&
                            btn9.Content.ToString() == "" || btn1.Content.ToString() == "X" && btn5.Content.ToString() == "X"
                            && btn9.Content.ToString() == "" || btn7.Content.ToString() == "X" && btn8.Content.ToString() == "X"
                            && btn9.Content.ToString() == "")
                        {
                            btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else if (btn5.Content.ToString() == "X" && btn2.Content.ToString() == "X" && btn8.Content.ToString() == ""
                           || btn7.Content.ToString() == "X" && btn9.Content.ToString() == "X" && btn8.Content.ToString() == "")
                        {
                            btn8.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                        else
                        {
                            if (btn1.Content.ToString() == "") btn1.Content = move;
                            else if (btn2.Content.ToString() == "") btn2.Content = move;
                            else if (btn3.Content.ToString() == "") btn3.Content = move;
                            else if (btn4.Content.ToString() == "") btn4.Content = move;
                            else if (btn5.Content.ToString() == "") btn5.Content = move;
                            else if (btn6.Content.ToString() == "") btn6.Content = move;
                            else if (btn7.Content.ToString() == "") btn7.Content = move;
                            else if (btn8.Content.ToString() == "") btn8.Content = move;
                            else btn9.Content = move;
                            counter++;
                            label();
                            GameResult();
                            break;
                        }
                }
            }
        }
        public void gamegridhide()
        {
            mygamegrid.Opacity = 0;
            Restart.Opacity = 0;
            MainMenu.Opacity = 0;
        }
        public void gamegridshow()
        {
            SinglePlayer.Width = 0;
            SinglePlayer.Height = 0;
            MultiplayerGame.Width = 0;
            MultiplayerGame.Height = 0;
            Score.Width = 0;
            Score.Height = 0;
            mygamegrid.Opacity = 100;
            Restart.Opacity = 100;
            MainMenu.Opacity = 100;
            label();
        }

        public void label()
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (counter == 1)
                Gamestatelabel.Content = "Press any of the buttons in the square to play";
            else if (counter != 1)
                Gamestatelabel.Content = $"{move} is playing";
        }
        private void GameResult()
        {
            if (btn1.Content.ToString() != "" && btn1.Content == btn2.Content && btn2.Content == btn3.Content ||
                btn1.Content.ToString() != "" && btn1.Content == btn5.Content && btn5.Content == btn9.Content ||
                btn1.Content.ToString() != "" && btn1.Content == btn4.Content && btn4.Content == btn7.Content ||
                btn2.Content.ToString() != "" && btn5.Content == btn2.Content && btn2.Content == btn8.Content ||
                btn3.Content.ToString() != "" && btn3.Content == btn5.Content && btn5.Content == btn7.Content ||
                btn3.Content.ToString() != "" && btn3.Content == btn6.Content && btn6.Content == btn9.Content ||
                btn4.Content.ToString() != "" && btn4.Content == btn5.Content && btn5.Content == btn6.Content ||
                btn7.Content.ToString() != "" && btn7.Content == btn8.Content && btn7.Content == btn9.Content)
            {
                if (btn1.Content.ToString() == "") btn1.Content = " ";
                if (btn2.Content.ToString() == "") btn2.Content = " ";
                if (btn3.Content.ToString() == "") btn3.Content = " ";
                if (btn4.Content.ToString() == "") btn4.Content = " ";
                if (btn5.Content.ToString() == "") btn5.Content = " ";
                if (btn6.Content.ToString() == "") btn6.Content = " ";
                if (btn7.Content.ToString() == "") btn7.Content = " ";
                if (btn8.Content.ToString() == "") btn8.Content = " ";
                if (btn9.Content.ToString() == "") btn9.Content = " ";
                counter = counter - 1;
                if (counter % 2 == 0)
                    move = "O";
                else
                    move = "X";
                if (!Artificialintelligence)
                {
                    if (counter % 2 == 0) multiplayero += 1;
                    else multiplayerx += 1;
                }
                else
                {
                    if (counter % 2 == 0) aiwin += 1;
                    else userwin += 1;
                }
                Gamestatelabel.Content = $"{move} won the game,click restart to play another game";
                counter = 9;
            }
            else if (btn1.Content.ToString() != "" && btn2.Content.ToString() != "" && btn3.Content.ToString() != "" && btn4.Content.ToString() != "" &&
               btn5.Content.ToString() != "" && btn5.Content.ToString() != "" && btn6.Content.ToString() != "" && btn7.Content.ToString() != "" &&
               btn8.Content.ToString() != "" && btn9.Content.ToString() != "")
            {
                if (Artificialintelligence) drawsvsai += 1;
                else drawsvsuser += 1;
                Gamestatelabel.Content = "Game ended in a tie, click restart to play another game";
            }
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn1.Content.ToString() == "")
            {
                btn1.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn2.Content.ToString() == "")
            {
                btn2.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn3.Content.ToString() == "")
            {
                btn3.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn4.Content.ToString() == "")
            {
                btn4.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn5.Content.ToString() == "")
            {
                btn5.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn6.Content.ToString() == "")
            {
                btn6.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn7.Content.ToString() == "")
            {
                btn7.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn8.Content.ToString() == "")
            {
                btn8.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (counter % 2 == 0)
                move = "O";
            else
                move = "X";
            if (btn9.Content.ToString() == "")
            {
                btn9.Content = move;
                counter++;
                label();
                GameResult();
                myAILogic();
            }
            else
                MessageBox.Show("Invalid move");
        }

        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            counter = 1;
            move = "X";
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            Gamestatelabel.Content = $"{move} is playing";
        }

        private void SinglePlayer_Click(object sender, RoutedEventArgs e)
        {
            Gamestatelabel.Opacity = 100;
            gamegridshow();
            Artificialintelligence = true;
        }

        private void MultiplayerGame_Click(object sender, RoutedEventArgs e)
        {
            Gamestatelabel.Opacity = 100;
            gamegridshow();
            Artificialintelligence = false;
        }

        private void Score_Click(object sender, RoutedEventArgs e)
        {
            SinglePlayer.Width = 0;
            SinglePlayer.Height = 0;
            MultiplayerGame.Width = 0;
            MultiplayerGame.Height = 0;
            Score.Width = 0;
            Score.Height = 0;
            mytblock.Width = 605;
            mytblock.Height = 349;
            mytblock.Text = "Games against computer \n" + $"Wins: {userwin} \n"
                + $"Losses: {aiwin} \n" + $"Draws: {drawsvsai} \n" +
                "Games against user \n" + $"X-Wins: {multiplayerx} \n"
                + $"O-wins: {multiplayero} \n" + $"Draws: {drawsvsuser}";
            MainMenu.Opacity = 100;
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            Gamestatelabel.Opacity = 0;
            counter = 1;
            move = "X";
            btn1.Content = "";
            btn2.Content = "";
            btn3.Content = "";
            btn4.Content = "";
            btn5.Content = "";
            btn6.Content = "";
            btn7.Content = "";
            btn8.Content = "";
            btn9.Content = "";
            Gamestatelabel.Content = $"{move} is playing";
            gamegridhide();
            tblockhide();
            SinglePlayer.Width = 350;
            SinglePlayer.Height = 68;
            MultiplayerGame.Width = 350;
            MultiplayerGame.Height = 68;
            Score.Height = 68;
            Score.Width = 350;
        }
    }
}
