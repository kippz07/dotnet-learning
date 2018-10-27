using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private bool _hasStarted = false;
        private DateTime _startTime;
        private TimeSpan _duration;

        public void Start()
        {
            try 
            {
                if (_hasStarted)
                    throw new InvalidOperationException();
                _startTime = DateTime.Now;
                System.Console.WriteLine("started");
                _hasStarted = true;
            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("Stopwatch has already been started");
            }
            
        }

        public void Stop()
        {
            try
            {
                if (!_hasStarted)
                    throw new InvalidOperationException();
                _duration = DateTime.Now - _startTime;
                System.Console.WriteLine("stopped");
                System.Console.WriteLine(_duration);
                _hasStarted = false;
            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("Stopwatch has not yet been started");
            }

        }
    }
}