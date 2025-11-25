using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreationHelper
{
    public static class JsonSerialization
    {
        static void SerializeObjectToJsonFile(List<Person> p_list, List<Context> c_list)
        {
            //string json = JsonConvert.SerializeObject(list);
            string json = JsonConvert.SerializeObject(new
            {
                p_list,
                c_list
            });
            File.WriteAllText("list.json", json);
        }

        static List<Person> DeserializePersonFromFile()
        {
            string json = File.ReadAllText("list.json");
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(json);
            return persons;
        }

        static List<Context> DeserializeContextFromFile()
        {
            string json = File.ReadAllText("list.json");
            List<Context> contexts = JsonConvert.DeserializeObject<List<Context>>(json);
            return contexts;
        }
    }
}
