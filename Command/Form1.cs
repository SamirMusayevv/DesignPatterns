using System;
using System.Windows.Forms;

namespace Command
{
    public partial class Form1 : Form
    {
        private TicTacToe Game;
        private TicTacToeCommand Command;
        private Button[,] buttons;

        public Form1()
        {
            InitializeComponent();

            Game = new TicTacToe(Field.X);
            Command = new TicTacToeCommand(Game);
            buttons = new Button[3, 3]
            {
                { button1, button2, button3 },
                { button4, button5, button6 },
                { button7, button8, button9 }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game.SetMove(0, 0, button1);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Game.SetMove(0, 1, button2);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Game.SetMove(0, 2, button3);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Game.SetMove(1, 0, button4);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Game.SetMove(1, 1, button5);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Game.SetMove(1, 2, button6);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Game.SetMove(2, 0, button7);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Game.SetMove(2, 1, button8);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Game.SetMove(2, 2, button9);
            if (Game.winner || Game.sum == 0)
                Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Command.Undo(buttons);
        }
    }
}
