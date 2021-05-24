﻿using System;
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

            if (player_Turn)
                button.Text = "X";
            else
                button.Text = "O";

            player_Turn = !player_Turn;
            button.Enabled = false;
            turn_Count++;

            winner_Check();


        }

        private void winner_Check()
        {
            bool check = false;

            // horizontal

            if ((button_1.Text == button_2.Text) && (button_2.Text == button_3.Text))
                check = true;
            else if ((button_4.Text == button_5.Text) && (button_5.Text == button_6.Text))
                check = true;
            else if ((button_7.Text == button_8.Text) && (button_8.Text == button_9.Text))
                check = true;

            // vertical

            if ((button_1.Text == button_4.Text) && (button_4.Text == button_7.Text))
                check = true;
            else if ((button_2.Text == button_5.Text) && (button_5.Text == button_8.Text))
                check = true;
            else if ((button_3.Text == button_6.Text) && (button_6.Text == button_9.Text))
                check = true;

            // diagonal

            if ((button_1.Text == button_5.Text) && (button_5.Text == button_9.Text))
                check = true;
            else if ((button_9.Text == button_5.Text) && (button_5.Text == button_7.Text))
                check = true;
            
            if (check) 
            {
                string winner = "";
                // should be opposite of the similar code previously since when winner wins, it is technically "player_Turn"'s move. 

                if (player_Turn) 
                    winner = "O";
                else 
                    winner = "X";

                MessageBox.Show("The winner is: " + winner);
            }

                  




        }

    }
        
}
