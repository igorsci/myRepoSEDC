using Models;
using Models.Enums;
using Models.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text;

namespace MarketStorageManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1, "HDD", Color.Black, Channel.Local, new SerialInfo("S001PN1", 1), new MarketValueDetails(10, 1000.50), ProductionCondition.New, new List<string>(){ "Macedonia", "Iraq"}),
                new Product(2, "CPU", Color.Gray, Channel.Local, new SerialInfo("S001PN111", 12), new MarketValueDetails(12, 500.70), ProductionCondition.Recycled, new List<string>(){ "China", "Iraq", "Iran", "Brazil"}),
                new Product(3, "SSD", Color.Gray, Channel.Online, new SerialInfo("S001PN9", 11), new MarketValueDetails(4, 780.99), ProductionCondition.New, new List<string>(){ "Macedonia", "Hungary"}),
                new Product(4, "CPU", Color.Black, Channel.Local, new SerialInfo("S001PN8", 10), new MarketValueDetails(8, 800.00), ProductionCondition.Recycled, new List<string>(){ "Albania", "Serbia"}),
                new Product(5, "Motherboard", Color.Yellow, Channel.Online, new SerialInfo("S002PN10", 5), new MarketValueDetails(2, 1500.50), ProductionCondition.New, new List<string>(){ "Angola", "Algeria", "American Samoa"}),
                new Product(6, "VideoCard", Color.Green, Channel.Online, new SerialInfo("S002PN9", 5), new MarketValueDetails(9, 999.99), ProductionCondition.Recycled, new List<string>(){ "Cameroon", "Iraq"}),
                new Product(7, "PowerSuply", Color.Red, Channel.Local, new SerialInfo("S002PN11", 6), new MarketValueDetails(1, 500.65), ProductionCondition.New, new List<string>(){ "Macedonia", "Denmark", "Norway"}),
                new Product(8, "RAM", Color.Green, Channel.Online, new SerialInfo("S003PN1", 3), new MarketValueDetails(14, 2700.67), ProductionCondition.Recycled, new List<string>(){ "Romania", "Russia", "Qatar"}),
                new Product(9, "Keyboard", Color.Black, Channel.Online, new SerialInfo("S004PN1", 9), new MarketValueDetails(6, 400.44), ProductionCondition.New, new List<string>(){ "Macedonia", "Russia", "Morocco", "Malta"}),
                new Product(10, "Mouse", Color.Orange, Channel.Local, new SerialInfo("S005PN234", 2), new MarketValueDetails(5, 67.89), ProductionCondition.Recycled, new List<string>(){ "Nigeria", "Peru"}),
                new Product(11, "Speaker", Color.White, Channel.Local, new SerialInfo("S007PNSG54", 1), new MarketValueDetails(50, 2300.11), ProductionCondition.New, new List<string>(){ "Portugal", "Poland", "Spain"}),
            };

            // part 3 =---------
            string dirPath = @"C:\Users\igor.mitevski\Desktop\IGOR M\myRepoGIT\CSharpAdvanced-Class12Exercise\Ex 12 Directory";
            FileInfo fi1 = new FileInfo(dirPath);
            Directory.CreateDirectory(dirPath);
            string txtPath = @"C:\Users\igor.mitevski\Desktop\IGOR M\myRepoGIT\CSharpAdvanced-Class12Exercise\Ex 12 Directory\TXTList.txt";
            string erroTxtPath = @"C:\Users\igor.mitevski\Desktop\IGOR M\myRepoGIT\CSharpAdvanced-Class12Exercise\Ex 12 Directory\ErrorLog.txt";

            FileInfo fi2 = new FileInfo(txtPath);
            

            try
            {
                using (StreamWriter sw = fi2.CreateText())
                {
                    foreach (var item in products)
                    {
                        sw.Write(item);
                    }


                }
                string read1 = File.ReadAllText(txtPath, Encoding.UTF8); //this is the default encoding

                Console.WriteLine(read1);
            }
            catch (Exception ex)
            {
                FileInfo fi3 = new FileInfo(erroTxtPath);
                using (StreamWriter sw = fi3.CreateText())
                {
                    sw.Write(ex.Message);
                    sw.Write(ex.Source);
                    sw.Write(ex.StackTrace);
                }

            }

            // read txt file

            
            // part 4 = -----------------

            // xml writing and reading 

            XmlSerializer serializer = new XmlSerializer(products.GetType());

            string path2 = @"C:\Users\igor.mitevski\Desktop\IGOR M\myRepoGIT\CSharpAdvanced-Class12Exercise\Ex 12 Directory\XMLProductList.xml";
            using (StreamWriter sw = new StreamWriter(path2))
            {
                serializer.Serialize(sw, products);
            }

            Console.WriteLine("xml list deserialized.");
            List<Product> empsDeserialized;
            using (StreamReader sr = new StreamReader(path2))
            {
                empsDeserialized = (List<Product>)serializer.Deserialize(sr);
            }
            foreach (var e in empsDeserialized)
            {
                Console.WriteLine(e.ToString());
            }


            // read and write json

            string json = JsonConvert.SerializeObject(products, Formatting.Indented);
            string pathjson = @"C:\Users\igor.mitevski\Desktop\IGOR M\myRepoGIT\CSharpAdvanced-Class12Exercise\Ex 12 Directory\JSONProductList.json";
            File.WriteAllText(pathjson, json);

            // Deserializing json collection
            Console.WriteLine("Deserializing json collection...");
            List<Product> NewEmpsDeserialized;

            string readJson = File.ReadAllText(pathjson);
            NewEmpsDeserialized = JsonConvert.DeserializeObject<List<Product>>(readJson);

            foreach (var e in NewEmpsDeserialized)
            {
                Console.WriteLine(e.ToString());
            }



            Console.ReadLine();
        }
    }
}
