using System;

namespace GPXReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GPX Reader");
            var url = new Uri($"D:/Documents/GitHub/GPXReader/gpx/Test.gpx");

            var data = GPXReader.ReadFile(url);
            // Set Break point here to view the imported file
            Console.WriteLine("Complete");

        }
    }
}
