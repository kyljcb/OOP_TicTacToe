using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_TicTacToe
{
    public partial class Form1 : Form
    {

        bool player_Turn = true;
        int turn_Count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (player_Turn) // acts as player 1
                button.Text = "X";

            else // acts as player 2
                button.Text = "O";

            player_Turn = !player_Turn; // function so that program knows whose turn it is. 
            button.Enabled = false; // function so that the button can not change once pressed.
            turn_Count++; // for draw check.

            winner_Check();

        }

        private void winner_Check()
        {
            bool check = false;

            // horizontal check
            // added (!button_no.Enabled) since the program reads the empty texts inside the buttons equal which satisfies our if statements.
            if ((button_1.Text == button_2.Text) && (button_2.Text == button_3.Text) && (!button_1.Enabled))
                check = true;
            else if ((button_4.Text == button_5.Text) && (button_5.Text == button_6.Text) && (!button_4.Enabled))
                check = true;
            else if ((button_7.Text == button_8.Text) && (button_8.Text == button_9.Text) && (!button_7.Enabled))
                check = true;

            // vertical check 

            
            if ((button_1.Text == button_4.Text) && (button_4.Text == button_7.Text) && (!button_1.Enabled))
                check = true;
            else if ((button_2.Text == button_5.Text) && (button_5.Text == button_8.Text) && (!button_2.Enabled))
                check = true;
            else if ((button_3.Text == button_6.Text) && (button_6.Text == button_9.Text) && (!button_3.Enabled))
                check = true;

            // diagonal check

            if ((button_1.Text == button_5.Text) && (button_5.Text == button_9.Text) && (!button_1.Enabled))
                check = true;
            else if((button_3.Text == button_5.Text) && (button_5.Text == button_7.Text) && (!button_3.Enabled))
                check = true;

            // final winner check

            if (check)
            {
                string winner = "";
                // should be opposite of the similar code previously since when a winner wins, it is technically "player_Turn"'s move next. 

                if (player_Turn)
                {
                    winner = "O";
                    oScore.Text = (Int32.Parse(oScore.Text) + 1).ToString();
                }
                   
                else
                {
                    winner = "X";
                    xScore.Text = (Int32.Parse(xScore.Text) + 1).ToString();
                }
                    
                MessageBox.Show("The winner is: " + winner);
            }
            // draw check
            else
            {
                if (turn_Count == 9)
                {
                    MessageBox.Show("There is no winner!");
                    drawScore.Text = (Int32.Parse(drawScore.Text) + 1).ToString();
                }
            }

        }

        private void button_NewGame(object sender, EventArgs e)
        {
            var new_Game = new Form1();
            new_Game.Show();
            this.Hide(); // hides the previous form
        }

        private void button_ExitGame(object sender, EventArgs e)
        {
            Application.Exit(); // exits the application

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // exit application when pressing the "x" button. 
        }

        private void x_Click(object sender, EventArgs e)
        {

        }
    }
}
