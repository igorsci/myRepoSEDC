using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SaveLoadHelper
    {
        public static void SaveToFile<T>(List<T> list, string path )
        {
            string json = JsonConvert.SerializeObject(list, Formatting.Indented);
            File.WriteAllText(path, json);

        }

        public static List<T> LoadFile<T>(List<T> list, string path)
        {
            string readFile = File.ReadAllText(path);
            var readJson = JsonConvert.DeserializeObject<List<T>>(readFile);
            return readJson;
        }
        // tuka impelementiras funkcionalnosti koi ke zacuvaat fajl i ke citaat od fajl
    }
}
