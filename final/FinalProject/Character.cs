abstract class Character
{
    protected PixelCluster _cluster;
    public Character(PixelCluster cluster) { _cluster = cluster; }
    public abstract string Display();
}