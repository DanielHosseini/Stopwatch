using System;
namespace StopWatch
{
    public class StopWatch
    {
        private bool IsRunning { get; set; }
        private DateTime Start { get; set; }
        private DateTime Stop { get; set; }
        private TimeSpan Duration { get;  set; }


        public void StartCount()
        {
            if (IsRunning)
                throw new InvalidOperationException("The stopwatch is already running.");

            IsRunning = true;
            Start = DateTime.Now;
        }

        public void StopCount()
        {
            if (!IsRunning)
                throw new InvalidOperationException("The stopwatch is not running.");

            IsRunning = false;
            Stop = DateTime.Now;
            GetDuration();

        }
        public void GetDuration(){

            Console.WriteLine("The Stopwatch has been running in total {0}", Duration = Start - Stop);
            Console.WriteLine("Testing visual studio version control");
        }
    }
}
