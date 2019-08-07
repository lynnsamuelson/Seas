using System;
using System.Collections.Generic;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace Seas
{

    class Name
    {
        [Index(0)]
        public string name { get; set; }
        [Index(1)]
        public string date { get; set;}
    }

    class CSV
    {

        public void ParseCSV()
        {
                       
            var records = new List<Name>();
            using (var reader = new StreamReader("C:/Users/Lynn Samuelson/source/repos/Seas 2/name_and_date.csv"))
            using (var csv = new CsvReader(reader))
            {
                                
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    string date = "";
                    try
                    {
                        DateTime thisDate = DateTime.Parse(csv.GetField("date"));
                        date = thisDate.ToString("d", DateTimeFormatInfo.InvariantInfo);
                    } catch (FormatException e)
                    {
                        Console.WriteLine("invalid date");
                    }
                    
                   
                    var record = new Name
                    {
                        name = csv.GetField<string>("name"),
                        date = date
                    };
                    records.Add(record);
                }

            }

            
            using (var writer = new StreamWriter("C:/Users/Lynn Samuelson/source/repos/Seas 2/file.csv")) 
            using (var csv = new CsvWriter(writer)) 
            {
                csv.WriteRecords(records);
            }

        }
    }
}
