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
            using (StreamReader reader = new StreamReader(url.AbsolutePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(gpxType), "http://www.topografix.com/GPX/1/1");
                gpxdata = (gpxType)serializer.Deserialize(reader);
            }
            return gpxdata;
        }
    }
}
