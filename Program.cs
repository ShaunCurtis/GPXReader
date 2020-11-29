using System;

namespace GPXReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GPX Reader");
            var url = new Uri($"D:/Documents/GitHub/GPXReader/gpx/Spain-Portugal-Autumn-2019.gpx");

            var data = GPXReader.ReadFile(url);
            // Set Break point
            Console.WriteLine("Complete");

        }
    }
}
