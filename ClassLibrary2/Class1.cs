using ClassLibrary6;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClassLibrary2
{
    public class ReadFile
    {
        public static List<Radar> GetData (string path)
        {
            StreamReader r = new StreamReader(path);
            string jsonString = r.ReadToEnd();

            var lst = JsonConvert.DeserializeObject<Radar>(jsonString, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy" });

            if (lst != null) return lst.Radar;
            return null;
        }

    }
}

