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
    public partial class Form1 : Form
    {
        
        bool turn = true; // true = X turn; false = O turn
        public static bool complayer = false;
        bool comStart = false;
        int turn_count = 0;
        bool turnChange = false;
        static String player1, player2;
        

        public Form1()
        {
            InitializeComponent();
        }

        public static void setPlayerNames(String n1, String n2)
        {
            player1 = n1;
            player2 = n2;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jyri Tauriainen", "TicTacToe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void computer()
         {
            if (complayer)
            {
                turn = !turn;
                // is there two in first row?
                if ((!A1.Enabled) && (!A2.Enabled) && (A1.Text == A2.Text) && (A3.Enabled)) 
                {
                    A3.Text = "O";
                    A3.Enabled = false;
                }
                else if ((!A2.Enabled) && (!A3.Enabled) && (A2.Text == A3.Text) && (A1.Enabled))
                {
                    A1.Text = "O";
                    A1.Enabled = false;
                }
                else if ((!A1.Enabled) && (!A3.Enabled) && (A1.Text == A3.Text) && (A2.Enabled))
                {
                    A2.Text = "O";
                    A2.Enabled = false;
                }
                // is there two in second row?
                else if ((!B1.Enabled) && (!B2.Enabled) && (B1.Text == B2.Text) && (B3.Enabled))
                {
                    B3.Text = "O";
                    B3.Enabled = false;
                }
                else if ((!B2.Enabled) && (!B3.Enabled) && (B2.Text == B3.Text) && (B1.Enabled))
                {
                    B1.Text = "O";
                    B1.Enabled = false;
                }
                else if ((!B1.Enabled) && (!B3.Enabled) && (B1.Text == B3.Text) && (B2.Enabled))
                {
                    B2.Text = "O";
                    B2.Enabled = false;
                }
                // is there two in third row?
                else if ((!C1.Enabled) && (!C2.Enabled) && (C1.Text == C2.Text) && (C3.Enabled))
                {
                    C3.Text = "O";
                    C3.Enabled = false;
                }
                else if ((!C2.Enabled) && (!C3.Enabled) && (C2.Text == C3.Text) && (C1.Enabled))
                {
                    C1.Text = "O";
                    C1.Enabled = false;
                }
                else if ((!C1.Enabled) && (!C3.Enabled) && (C1.Text == C3.Text) && (C2.Enabled))
                {
                    C2.Text = "O";
                    C2.Enabled = false;
                }
                // is there two in 1 column?
                else if ((!A1.Enabled) && (!B1.Enabled) && (A1.Text == B1.Text) && (C1.Enabled))
                {
                    C1.Text = "O";
                    C1.Enabled = false;
                }
                else if ((!B1.Enabled) && (!C1.Enabled) && (B1.Text == C1.Text) && (A1.Enabled))
                {
                    A1.Text = "O";
                    A1.Enabled = false;
                }
                else if ((!A1.Enabled) && (!C1.Enabled) && (A1.Text == C1.Text) && (B1.Enabled))
                {
                    B1.Text = "O";
                    B1.Enabled = false;
                }
                // is there two in 2 column?
                else if ((!A2.Enabled) && (!B2.Enabled) && (A2.Text == B2.Text) && (C2.Enabled))
                {
                    C2.Text = "O";
                    C2.Enabled = false;
                }
                else if ((!B2.Enabled) && (!C2.Enabled) && (B2.Text == C2.Text) && (A2.Enabled))
                {
                    A2.Text = "O";
                    A2.Enabled = false;
                }
                else if ((!A2.Enabled) && (!C2.Enabled) && (A2.Text == C2.Text) && (B2.Enabled))
                {
                    B2.Text = "O";
                    B2.Enabled = false;
                }
                // is there two in 3 column?
                else if ((!A3.Enabled) && (!B3.Enabled) && (A3.Text == B3.Text) && (C3.Enabled))
                {
                    C3.Text = "O";
                    C3.Enabled = false;
                }
                else if ((!B3.Enabled) && (!C3.Enabled) && (B3.Text == C3.Text) && (A3.Enabled))
                {
                    A3.Text = "O";
                    A3.Enabled = false;
                }
                else if ((!A3.Enabled) && (!C3.Enabled) && (A3.Text == C3.Text) && (B3.Enabled))
                {
                    B3.Text = "O";
                    B3.Enabled = false;
                }
                // Diagonal Checks - A1 - C3
                else if ((!A1.Enabled) && (!B2.Enabled) && (A1.Text == B2.Text) && (C3.Enabled))
                {
                    C3.Text = "O";
                    C3.Enabled = false;
                }
                else if ((!B2.Enabled) && (!C3.Enabled) && (B2.Text == C3.Text) && (A1.Enabled))
                {
                    A1.Text = "O";
                    A1.Enabled = false;
                }
                else if ((!A1.Enabled) && (!C3.Enabled) && (A1.Text == C3.Text) && (B2.Enabled))
                {
                    B2.Text = "O";
                    B2.Enabled = false;
                }
                // Diagonal Checks - A3 - C1
                else if ((!A3.Enabled) && (!B2.Enabled) && (A3.Text == B2.Text) && (C1.Enabled))
                {
                    C1.Text = "O";
                    C1.Enabled = false;
                }
                else if (!(B2.Enabled) && (!C1.Enabled) && (B2.Text == C1.Text) && (A3.Enabled))
                {
                    A3.Text = "O";
                    A3.Enabled = false;
                }
                else if ((A3.Enabled == C1.Enabled) && (A3.Text == C1.Text) && (B2.Enabled))
                {
                    B2.Text = "O";
                    B2.Enabled = false;
                }
                                

                // let add random?
                else if (A1.Enabled)
                {
                    A1.Text = "O";
                    A1.Enabled = false;
                }
                else if (A2.Enabled)
                {
                    A2.Text = "O";
                    A2.Enabled = false;
                }
                else if (A3.Enabled)
                {
                    A3.Text = "O";
                    A3.Enabled = false;
                }
                else if (B3.Enabled)
                {
                    B3.Text = "O";
                    B3.Enabled = false;
                }
                else if (B2.Enabled)
                {
                    B2.Text = "O";
                    B2.Enabled = false;
                }
                else if (B1.Enabled)
                {
                    B1.Text = "O";
                    B1.Enabled = false;
                }
                else if (C3.Enabled)
                {
                    C3.Text = "O";
                    C3.Enabled = false;
                }
                else if (C2.Enabled)
                {
                    C2.Text = "O";
                    C2.Enabled = false;
                }
                else if (C1.Enabled)
                {
                    C1.Text = "O";
                    C1.Enabled = false;
                }
                turn_count++;
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turn_count++;
            bool winner = checkForWinner();
            if ((!winner) && (turn_count != 9))
            {
                computer();
                checkForWinner();
            }
            
                
        }

        public bool checkForWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_a_winner = true;

            //verical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_a_winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                there_is_a_winner = true;
          

            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = player2;
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                }
                else
                {
                    winner = player1;
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                }
                MessageBox.Show(winner + " Wins!", "JIIHAA!");
                
            }//end If
            else
            {
                if (turn_count == 9)
                {
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("Tie!", "OH!");
                }
            }
            return (there_is_a_winner);
        }//end checkForWinner

        private void disableButtons()
        {
            foreach(Control c in Controls)
            {
                try
                {
                              
                    Button b = (Button)c;
                    b.Enabled = false;
                }//end of try
                catch { }
            }
        }//end foreach           
            

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            turn_count = 0;
            turnChange = !turnChange;
            if (turnChange)
            {
                turn = false; // O Turn to start the new game
            }
            else turn = true; // X Trun to start the new game

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }//end of try
                catch { }
            }//end foreach
            if (complayer)
            {
                comStart = !comStart;
                if (comStart)
                {
                    turn = false;
                    computer();
                }
            }
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {            
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            }//end If
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
               b.Text = "";                
            }//end If
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void resetWinCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            draw_count.Text = "0";
            x_win_count.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.ShowDialog();
            label1.Text = player1;
            label3.Text = player2;
        }
    }
}
