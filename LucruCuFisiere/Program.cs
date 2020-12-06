using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LucruCuFisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] lines = { "Linia 1", "Linia 2", "Linia 3", "Linia 4", "Linia 5" };
            ////System.IO.File.WriteAllLines(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt", lines);
            //string text = "Brașov is located in the central part of the country, about 166 kilometres (103 miles) north of Bucharest and 380 kilometres (236 miles) from the Black Sea. It is surrounded by the Southern Carpathians and is part of the historical region of Transylvania.";
            //System.IO.File.WriteAllText(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt", text);
            ////using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt",true))
            //{
            //    foreach (var line in lines)
            //    {
            //        if (line.Contains("3"))
            //        { file.WriteLine(line);
            //        }
            //    }
            //}
            ////string readText = System.IO.File.ReadAllText(@"C:\AgileHUBTestProj\AgileHUBReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //var lines = System.IO.File.ReadLines(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt");
            ////foreach (var line in lines)
            //{
            ////    Console.WriteLine(line);
            //}
            ////string line;            
            // System.IO.StreamReader file = new System.IO.StreamReader(@"C:\AgileHUBTestProj\AgileHUBReadFiles\LucruCuFisiere\LucruCuFisiere\WriteLinesSample.txt");
            //var lines = System.IO.File.ReadAllText(@"C:\Users\Ariana\Desktop\Agilehub_Automation\LucruCuFisiere\WriteLinesSample.txt");
            //while (!(line = file.ReadLine()).Contains("NumeScenariu"))
            //{
            //    Console.WriteLine(line);
            //}            //foreach (var line in lines)
            //{
            //    if (line.Contains("NumeScenariu"))
            //    {
            //        Console.WriteLine(line);
            //    }
            //}            //file.Close();
            //var myValue = ScenarioDto.ReadXML();
            //Console.WriteLine($"NUmele Scenariului este: {myValue.TestCaseName}, Numele properietatii 2 este :{myValue.TestInput}, proprietatea 3 este: {myValue.OtherInfo} ");
            //Console.ReadKey();

            //ScenarioDto.JsonSerialize();
            //Console.ReadKey();


            var myList = ScenarioDto.LoadValuesFromJsonFile();
            //ca sa nu mai iteram
            foreach (var element in myList)
            {
                Console.WriteLine($"Element {myList.IndexOf(element)}: {element.TestCaseName},  {element.TestInput},  {element.OtherInfo}, numarul de valori in campul Values{element.Values.Count}");
            }
        }
    }
}
