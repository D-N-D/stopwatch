using System;

namespace StopWatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var stopwatch = new Stopwatch();
            if (stopwatch.IsStarted != true)
            {
				stopwatch.Start();
			}
		}  
    }
}
