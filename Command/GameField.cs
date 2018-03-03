using System.Collections.Generic;

namespace Command
{
    class GameField
    {
        public Field[,] field;
        private static GameField Game;

        public GameField()
        {
            field = new Field[3,3]
            {
                { Field.Empty, Field.Empty, Field.Empty },
                { Field.Empty, Field.Empty, Field.Empty },
                { Field.Empty, Field.Empty, Field.Empty }
            };
        }

        static public GameField GetInstance()
        {
            Game = Game ?? new GameField();
            return Game;
        }
    }
}
