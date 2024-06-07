using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LabResearchTester
{
    public class PlayerInfos
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }
    }

    public class PlayerTester
    {
        string path = "";

        public PlayerTester(string path)
        {
            this.path = path;
        }

        public PlayerInfos GetPlayerInfos()
        {
            string jSonString = File.ReadAllText(path);

            using (var reader = new StringReader(jSonString))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }

            return null;
        }
    }
}
