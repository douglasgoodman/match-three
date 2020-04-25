using System.Windows.Controls;

namespace MatchThree.WPF.Controls
{
    /// <summary>
    /// Interaction logic for BoardControl.xaml
    /// </summary>
    public partial class GameBoardControl : UserControl
    {
        public GameBoard GameBoard { get; set; }

        public GameBoardControl()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            for (int row = GameBoard.MinRow; row <= GameBoard.MaxRow; row++)
            {
                for (int column = GameBoard.MinColumn; column <= GameBoard.MaxColumn; column++)
                {
                    var tile = new RegularTileControl(GameBoard.Tiles[row, column].Color);
                    AddToGrid(tile, row, column);
                }
            }
        }

        private void AddToGrid(RegularTileControl tile, int row, int column)
        {
            Grid.SetRow(tile, row);
            Grid.SetColumn(tile, column);
            MainGrid.Children.Add(tile);
        }
    }
}
