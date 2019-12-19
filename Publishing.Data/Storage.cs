using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Publishing.Data
{
    public class Storage
    {
        public void Save(List<DataSpace> info)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"data.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<DataSpace> Load()
        {
            JsonSerializer serializer = new JsonSerializer();
            List<DataSpace> result = new List<DataSpace>();

            using (StreamReader sr = new StreamReader(@"data.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<DataSpace>>(reader);
                sr.Close();
            }

            return result;
        }

        //For the tests
        public void Save(List<DataSpace> info, string file)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter($@"{file}.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, info);
                sw.Close();
            }
        }

        public List<DataSpace> Load(string file)
        {
            JsonSerializer serializer = new JsonSerializer();
            List<DataSpace> result = new List<DataSpace>();

            using (StreamReader sr = new StreamReader($@"{file}.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                result = serializer.Deserialize<List<DataSpace>>(reader);
                sr.Close();
            }

            return result;
        }
    }
}
