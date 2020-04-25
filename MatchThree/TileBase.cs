namespace MatchThree
{
    public class TileBase
    {
        public bool IsSpecial { get; set; }
        public bool IsSelected { get; set; }
        public Color Color { get; set; }

        public override string ToString() => Color.ToString();
    }
}
