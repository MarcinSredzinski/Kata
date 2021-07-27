using System.Diagnostics;

namespace KataConsole.Sorting.Measurements
{
    public class TimeOfExecutionMeasurement : IObserver
    {
        private readonly TimeOfExecutionDataStore _timeOFExecution;

        public TimeOfExecutionMeasurement(TimeOfExecutionDataStore timeOfExecution)
        {
            _timeOFExecution = timeOfExecution;
        }

        public void Update(ISubject subject)
        {
            if (subject.IsRunning)
            {
                _timeOFExecution.Stopwatch = Stopwatch.StartNew();
            }
            else
            {
                _timeOFExecution.Stopwatch.Stop();
                _timeOFExecution.ElapsedTime = _timeOFExecution.Stopwatch.ElapsedTicks;
            }
        }
    }
}
