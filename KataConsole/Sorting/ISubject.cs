namespace KataConsole.Sorting
{
    public interface ISubject
    {
        ISubject Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        public int[] ToSort { get; }
        public int LowerValue { get; }
        public bool IsRunning { get; set; }
    }
}
