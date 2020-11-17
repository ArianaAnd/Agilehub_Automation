using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucruCuFisiere
{
    public class ScenarioDto
    {
        public string TestCaseName { get; set; }
        public string TestInput { get; set; }
        public string OtherInfo { get; set; }

        public static void WriteXML()
        {
            ScenarioDto myScenario = new ScenarioDto();
            myScenario.TestCaseName = "Scenariul 1";
            myScenario.TestInput = "andrisan_ariana@yahoo.com";
            myScenario.OtherInfo = "password123";
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            var path = @"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteXML.txt";
            // ScenarioDto myScenario = new ScenarioDto {TestCaseName="Scenariul1", TestInput="andrisan_ariana@yahoo.com", OtherInfo="password123" };
            //var writer = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            //var writeFile = new System.IO.StreamWriter("C:\\Users\\Ariana\\Desktop\\Agilehub_Automation\\LucruCuFisiere\\WriteXML.txt");
            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, myScenario);
            file.Close();

        }

        public static ScenarioDto ReadXML()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ScenarioDto));
            var path = @"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\ReadXML.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            ScenarioDto myScenarioDto = (ScenarioDto) reader.Deserialize(file);
            file.Close();
            return myScenarioDto;
        }

    }
}
