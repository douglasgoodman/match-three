using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchThree
{
    public class GameBoard
    {
        public const int Height = 9;
        public const int Width = 9;
        public const int MinColumn = 0;
        public const int MaxColumn = 8;
        public const int MinRow = 0;
        public const int MaxRow = 8;

        private readonly Random random = new Random();
        private readonly IList<Color> colors;

        public TileBase[,] Tiles { get; } = new TileBase[Height, Width];

        public GameBoard(IList<Color> colors)
        {
            this.colors = colors;

            for (int row = MinRow; row <= MaxRow; row++)
            {
                for (int column = MinColumn; column <= MaxColumn; column++)
                {

                    Tiles[row, column] = new RegularTile(colors[random.Next(colors.Count())]);
                }
            }
        }
    }
}
