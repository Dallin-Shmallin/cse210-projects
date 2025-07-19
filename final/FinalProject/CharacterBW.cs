
class CharacterBW : Character
{
    private string _character = "";

    public CharacterBW(PixelCluster cluster) : base(cluster) { }

    public override string Display()
    {
        return _character;
    }
}
