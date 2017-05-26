using System;
namespace StopWatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStarted;

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        public bool IsStarted
        {
            get { return _isStarted; }
            set { _isStarted = value; }
        }

        public void Start()
        {
            this.IsStarted = true;
            Console.WriteLine("Enter start to start");
			string line = Console.ReadLine();

			if (line != "start")
			{
				Start();
            }
			else
			{
                this.StartTime = DateTime.Now;
                this.EndTime = End();
                TimeSpan totalTime = this.EndTime - this.StartTime;
                Console.WriteLine("Total time: " + totalTime);
                this.IsStarted = false;

				Console.WriteLine("Again?\n yes/no");
				string answer = Console.ReadLine();
                if (answer != "no")
				{
					Start();
				}


				return;
			}
		}

        public static DateTime End ()
        {
			Console.WriteLine("Enter end to stop");
			string line = Console.ReadLine();

			if (line != "end")
			{
				End();
			}


			return DateTime.Now;            
        }
       
    }
}
