using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsStudy
{

   public class InsitesMain
    {

        public static void Execute()
        {
            string jsonString = @"
                {""insights"":{""data"":[{""impressions"":""1648"",""date_start"":""2021-11-03"",""date_stop"":""2021-12-02""}],""paging"":{ ""cursors"":{ ""before"":""MAZDZD"",""after"":""MAZDZD""} }},""id"":""23849261337680001""}
            ";

            var pocoObject = JsonConvert.DeserializeObject<InsitesContainer>(jsonString);

            Console.ReadKey();
        }

    }

    public class InsitesContainer
    {
        public string id { get; set; }
        public Insites insights { get; set; }
    }

    public class Insites
    {        
        public List<Data> data { get; set; }
        public Paging paging { get; set; }
    }

    public class Data
    {
        public string date_start { get; set; }
        public string date_stop        { get; set; }
        public string impressions { get; set; }
    }
    public class Paging
    {
        public Cursors cursors { get; set; }
    }

    public class Cursors
    {
        public string after { get; set; }
        public string before { get; set; }
    }
}
