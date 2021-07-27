using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataConsole.Sorting.Measurements
{
   public class TimeOfExecutionDataStore
    {
        public Stopwatch Stopwatch { get; set; }
        public long ElapsedTime { get; set; }
    }
}
