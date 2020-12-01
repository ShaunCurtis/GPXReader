using System;
using System.IO;
using System.Xml.Serialization;

namespace GPXReader
{
    public class GPXReader
    {
        public static gpxType ReadFile(Uri url)
        {
            gpxType gpxdata = null;
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

        public static bool ReadFile(Uri url, out gpxType gpxdata)
        {
            gpxdata = null;
            try
            {
                using (StreamReader reader = new StreamReader(url.AbsolutePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(gpxType), "http://www.topografix.com/GPX/1/1");
                    gpxdata = serializer.Deserialize(reader) as gpxType;
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Error has occurred accessing file {url.AbsolutePath}.{Environment.NewLine} Details:{Environment.NewLine} {e.StackTrace}.");
            }
            return false;
        }

        public static bool WriteFile(gpxType data, Uri url)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(url.AbsolutePath, false))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(gpxType), "http://www.topografix.com/GPX/1/1");
                    serializer.Serialize(writer, data);
                    writer.Flush();
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An Error has occurred accessing file {url.AbsolutePath}.{Environment.NewLine} Details:{Environment.NewLine} {e.StackTrace}.");
            }
            return false;
        }
    }
}
