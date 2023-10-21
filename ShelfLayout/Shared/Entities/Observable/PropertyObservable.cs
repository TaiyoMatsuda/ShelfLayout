using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ShelfLayout.Shared.Entities.Observable
{

    public interface IPropertyObservable<T> : IObservable<T>
    {
        public T Value { get; }
    }

    public class PropertyObservable<T> : IPropertyObservable<T>
    {
        public BehaviorSubject<T> Subject { get; set; }
        public PropertyObservable(T initial)
        {
            Subject = new(initial);
        }
        public IDisposable Subscribe(IObserver<T> observer)
        {
            return Subject.Subscribe(observer);
        }
        public T Value => Subject.Value;

        // Notify the value updated to subscribers
        public void Notify(T new_value)
        {
            Subject.OnNext(new_value);
        }
    }
}
