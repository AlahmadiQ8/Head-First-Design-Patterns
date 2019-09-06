
namespace ObserverPattern
{
    public interface ISubject<out T>
    {
        void RegisterObserver(IObserver<T> o);
        void RemoveObserver(IObserver<T> o);
        void NotifyObservers();
    }
}