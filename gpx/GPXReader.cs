using System;
using System.IO;
using System.Xml.Serialization;

namespace GPXReader
{
    public class GPXReader
    {
        public static gpxType ReadFile(Uri url)
        {
            var gpxdata = new gpxType();
            try
            {
                using (StreamReader reader = new StreamReader(url.AbsolutePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(gpxType), "http://www.topografix.com/GPX/1/1");
                    gpxdata = serializer.Deserialize(reader) as gpxType;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Error has occurred accessing file {url.AbsolutePath}.{Environment.NewLine} Details:{Environment.NewLine} {e.StackTrace}.");
            }
            return gpxdata;
        }
    }
}
