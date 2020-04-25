using System.Collections.Generic;

namespace MatchThree
{
    public class Game
    {
        public GameBoard GameBoard { get; set; }

        public Game()
        {
            var colors = new List<Color> { Color.Red, Color.Blue, Color.Orange, Color.Purple };

            GameBoard = new GameBoard(colors);
        }
    }
}
