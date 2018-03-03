using System.Collections.Generic;
using System.Windows.Forms;

namespace Command
{
    interface ICommand
    {
        void Undo(Button[,] buttons);
    }

    class TicTacToeCommand : ICommand
    {
        private GameField _gameField;
        private TicTacToe Game;
        private Stack<int> X;
        private Stack<int> Y;

        public TicTacToeCommand(TicTacToe Game)
        {
            _gameField = GameField.GetInstance();
            this.Game = Game;
            X = new Stack<int>();
            Y = new Stack<int>();
        }

        public void Undo(Button[,] buttons)
        {
            if (Game.X.Count != 0 && Game.Y.Count != 0)
            {
                var X2 = Game.X.Pop();
                var Y2 = Game.Y.Pop();
                _gameField.field[X2, Y2] = Field.Empty;
                Game.sum++;
                Game.current--;
                buttons[X2, Y2].Text = "";
            }
        }
    }
}
