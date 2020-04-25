using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MatchThree;

namespace MatchThree.WPF.Controls
{
    /// <summary>
    /// Interaction logic for RegularTileControl.xaml
    /// </summary>
    public partial class RegularTileControl : UserControl
    {
        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register("Color", typeof(Brush), typeof(RegularTileControl), new PropertyMetadata(Brushes.Red));
        public Brush Color
        {
            get => GetValue(ColorProperty) as Brush;
            set => SetValue(ColorProperty, value);
        }

        public RegularTileControl(Color color)
        {
            InitializeComponent();
            SetColor(color);
        }

        private void SetColor(Color color)
        {
            switch (color)
            {
                case MatchThree.Color.Red:
                    Color = Brushes.Red;
                    break;
                case MatchThree.Color.Orange:
                    Color = Brushes.Orange;
                    break;
                case MatchThree.Color.Yellow:
                    Color = Brushes.Yellow;
                    break;
                case MatchThree.Color.Green:
                    Color = Brushes.Green;
                    break;
                case MatchThree.Color.Blue:
                    Color = Brushes.Blue;
                    break;
                case MatchThree.Color.Purple:
                    Color = Brushes.Purple;
                    break;
            }
        }
    }
}
