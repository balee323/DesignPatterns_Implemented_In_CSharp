namespace DesignPatterns.ObserverPattern
{
    public interface IWatcher<T>
    {
        void BargainAlert(T someObject);
    }
}