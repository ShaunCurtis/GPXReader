using System;
using System.IO;
using CEC.OSM.Data.Gpx;

namespace GPXImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var url = new Uri($"D:/Documents/GitHub/CEC.OSM/GPXImporter/gpx/Spain-Portugal-Autumn-2019.gpx");

            var data = GPXReader.ReadFile(url);


        }
    }
}
