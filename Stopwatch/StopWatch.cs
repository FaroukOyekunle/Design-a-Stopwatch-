using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    // The job of this class is to simulate a stopwatch. It provide two methods: Which is the Start and Stop.
    // We Would call the start method first, and the stop method next. 
    // Then we ask the stopwatch about the duration between the start and stop period.
    // The Duration would be a value in TimeSpan.
    // Then i display the duration onto the console.


    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning;

        // Here is the Start Method
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("StopWatch is already running.");

            _isRunning = true;
            _startTime = DateTime.Now;

        }

        // And here is alsothree stop methid
        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("StopWatch is not running.");
            _isRunning = false;
            _endTime = DateTime.Now;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
