using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___TicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.setPlayerNames(p1.Text, p2.Text);
            Form1.computer();
            this.Close();

        }

        private void p2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
                button1.PerformClick();        
        }

        private void radio_button2(object sender, EventArgs e)
        {
            p2.Text = "";
            p2.Enabled = true;
            Form1.computer_turn = false;
        }

        private void radio_button1(object sender, EventArgs e)
        {
            
            p2.Text = "Computer";
            p2.Enabled = false;
            Form1.computer_turn = true;

        }
    }
}
