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
        int counter=1;
        string move;

        public MainWindow()
        {
            InitializeComponent();
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
            if(btn1.Content.ToString() != "" && btn1.Content == btn2.Content && btn2.Content == btn3.Content ||
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
                Gamestatelabel.Content = $"{move} won the game,click restart to play another game";
            }
            else if(btn1.Content.ToString() != "" && btn2.Content.ToString() != "" && btn3.Content.ToString() != "" && btn4.Content.ToString() != "" &&
               btn5.Content.ToString() != "" && btn5.Content.ToString() != "" && btn6.Content.ToString() != "" && btn7.Content.ToString() != "" &&
               btn8.Content.ToString() != "" && btn9.Content.ToString() != "")
                Gamestatelabel.Content = "Game ended in a tie, click restart to play another game";
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
    }
}
