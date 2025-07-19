using System.Runtime.CompilerServices;
class CharacterBW : Character
{
    public CharacterBW(PixelCluster cluster) : base(cluster) { }
    public override string ToAscii()
    {
        // Convert cluster to ASCII character (black and white)
        return "#"; // placeholder
    }
}