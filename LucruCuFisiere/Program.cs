using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucruCuFisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4" };
            //@vede ca are un path, ii spunem unde scriem si ce sa scrie(lines)
            // System.IO.File.WriteAllLines(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\", lines);
            //  Console.WriteLine("Liniile au fost scrise in fisier");
            //  Console.ReadLine();

            //string text = "Blaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //System.IO.File.WriteAllText(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt", text);

            //foreach (var line in readLines)
            //{
            //    Console.WriteLine(line);
            //}

            //string line;
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt");

            //while ((line = file.ReadLine()) != string.Empty)
            //{
            //    Console.WriteLine(line);
            //}

            //file.Close();
            //System.IO.File.WriteAllText(@"C:\Users\radu.flitar\DEV\Learning\AgileHub\AutomationTestingAgileHub\ReadWriteFromFiles\WriteLinesSample.txt", text);

            // ScenarioDto.WriteXML();
           

            var myScenario = ScenarioDto.ReadXML();

            Console.WriteLine($"Numele scenariului este {myScenario.TestCaseName}, numele proprieatii este {myScenario.TestInput}, numele proprietatii 3 este {myScenario.OtherInfo}");
            Console.ReadKey();

        }
    }
}
