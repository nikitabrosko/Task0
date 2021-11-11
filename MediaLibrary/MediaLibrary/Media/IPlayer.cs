namespace MediaLibrary.Media
{
    public interface IPlayer
    {
        public void Play(IMedia media);
        public void Stop();
    }
}