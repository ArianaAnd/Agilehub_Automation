﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tema28.TestData
{
    public class MyTestData
    {
        public string TestCaseName { get; set; }
        public string Input { get; set; }
        public string OtherInfo { get; set; }

        public static List<MyTestData> LoadValuesFromJsonFile()
        {
            var myFile = @"C:\Users\Ariana\Desktop\Agilehub_Automation\Tema28\TestData\MyJsonExample2.json";
            try
            {
                using (var reader = new StreamReader(myFile))
                {
                    var json = reader.ReadToEnd();
                    var config = JObject.Parse(json).SelectToken("ScenarioDto").ToString();
                    var myTestDataList = JsonConvert.DeserializeObject<List<MyTestData>>(config);

                    return myTestDataList;


                }
            }

            catch (Exception)
            {
                throw new Exception($"There is a problem with file {myFile}");
            }

        }
    }
}
