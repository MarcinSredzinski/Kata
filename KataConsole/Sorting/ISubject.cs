namespace KataConsole.Sorting
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        public int[] ToSort { get; }
        public int LowerValue { get; }
    }
}
