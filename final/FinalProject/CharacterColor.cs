class CharacterColor : Character
{
    private string _character = "";
    public CharacterColor(PixelCluster cluster) : base(cluster) { }
    public override string Display()
    {
        return _character;
    }
}