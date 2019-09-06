namespace ObserverPattern
{
    public interface IObserver<in T>
    {
        void Update(T info);
    }
}