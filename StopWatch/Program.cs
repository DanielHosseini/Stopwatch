using System;

namespace StopWatch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Startwatch application");
            Console.WriteLine("Write start to START the stopwatch");
			Console.WriteLine("Write stop to STOP the stopwatch");
			Console.WriteLine("Write exit to EXIT the stopwatch");

			var running = true;
            StopWatch stopWatch = new StopWatch();


			while (running)
            {
                var input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "start":
                        stopWatch.StartCount();
                        break;
                    case "stop":
                        stopWatch.StopCount();
						break;
                    case "exit":
                        Console.WriteLine("The application has ended.");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
