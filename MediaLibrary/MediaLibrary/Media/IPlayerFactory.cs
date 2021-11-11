namespace MediaLibrary.Media
{
    public interface IPlayerFactory
    {
        IPlayer Create(IMedia media);
    }
}
