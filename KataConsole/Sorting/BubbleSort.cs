using System.Collections.Generic;

namespace KataConsole.Sorting
{
    public class BubbleSort : ISubject
    {
        private List<IObserver> _observers = new();
        public int[] ToSort { get; private set; }
        public int LowerValue { get; private set; }
        public bool IsRunning { get; set; }
        public void Sort(ref int[] toSort)
        {
            IsRunning = true;
            ToSort = toSort;
            Notify();
            bool isMoved;
            do
            {
                isMoved = false;
                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (toSort[i] > toSort[i + 1])
                    {
                        LowerValue = toSort[i + 1];
                        toSort[i + 1] = toSort[i];
                        toSort[i] = LowerValue;
                        isMoved = true;
                        ToSort = toSort;
                        Notify();
                    }
                }
            } while (isMoved);

            IsRunning = false;
            Notify();
        }

        public ISubject Attach(IObserver observer)
        {
            _observers.Add(observer);
            return this;
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer)) _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
