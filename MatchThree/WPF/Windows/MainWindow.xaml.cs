using System.Windows;

namespace MatchThree.WPF.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Game game = new Game();

        public MainWindow()
        {
            InitializeComponent();
            GameBoardControl.GameBoard = game.GameBoard;
        }
    }
}
