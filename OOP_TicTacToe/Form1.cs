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

        private void button9_Click(object sender, EventArgs e)
        {
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

            player_Turn = false;


        }
    }
}
