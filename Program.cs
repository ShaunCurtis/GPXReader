using System;

namespace GPXReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GPX Reader");

            var data = GPXReader.ReadFile(new Uri($"D:/Documents/GitHub/GPXReader/gpx/Test.gpx"));

            Console.WriteLine($"Read file");

            // Set Break point here to view the imported file

            Console.WriteLine($"Writing output file");

            GPXReader.WriteFile(data, new Uri($"D:/Documents/GitHub/GPXReader/gpx/output.gpx"));

            Console.WriteLine("Complete");

        }
    }
}
