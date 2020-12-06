using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LucruCuFisiere
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }
        public IList<string> Values { get; set; }

        public static void WriteXML()
        {
            ScenarioDto myScenario = new ScenarioDto { TestCaseName = "Scenariul 1", TestInput = "andrisan_ariana@yahoo.com", OtherInfo = "pasword123" };
            //myScenario.TestCaseName = "Scenariul1";
            //myScenario.TestInput = "casian.stupari@gmail.com";
            //myScenario.OtherInfo = "pasword123";
            //System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));           
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            var writeFile = new System.IO.StreamWriter(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteXML.xml");          
            //var path = ;
            ////System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(writeFile, myScenario);
            writeFile.Close();
        }
        public static ScenarioDto ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto)); 
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteXML.xml"); 
            ScenarioDto myScenarioDto = (ScenarioDto)reader.Deserialize(file); 
            file.Close();
            return myScenarioDto;
        }

        public static void JsonSerialize()
        {
            ScenarioDto myObject = new ScenarioDto
            {
                TestCaseName = "TestCase1",
                TestInput = "My input",
                OtherInfo = "Other Information",
                Values = new List<string> { "value1", "value2", "value3" }

            };
         



            //string myJson = JsonConvert.SerializeObject(myObject, Formatting.Indented);
            //Console.WriteLine(myJson);
            File.WriteAllText(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\MyJsonExample.json", JsonConvert.SerializeObject(myObject, Formatting.Indented));
            //curata singur dupa ce foloseste codul, putem evita probleme cand folosim mai multe fisiere din cauza incarcarii memoriei
            using (StreamWriter file =
                File.CreateText(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\MyJsonExample2.json"))
            {
                JsonSerializer serializator = new JsonSerializer();
                serializator.Serialize(file, myObject);
            }
            Console.WriteLine("Fisierul a fost creat");


        }

        public static void JsonDeserialize()
        {
            string myJson = @"{TestCaseName = 'TestCase1', TestInput = 'My input', OtherInfo = 'Other Information'}";
            ScenarioDto myObject = JsonConvert.DeserializeObject<ScenarioDto>(myJson);
            Console.WriteLine(myObject.TestCaseName);
        }

        public static List<ScenarioDto> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\MyJsonExample2.json";
            try
            {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<ScenarioDto>>(config);

                    return myTestDataList;


                }
            }
            
            catch (Exception)
            {
                throw  new Exception($"There is a problem with file {myFile}");
            }
        }
    }
}
