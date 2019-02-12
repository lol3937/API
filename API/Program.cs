using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://api.nobelprize.org/v1/laureate.json");
            var request = new RestRequest("/", Method.GET);
            IRestResponse response = client.Execute(request);
            String content = response.Content;
            RootObject menu = JsonConvert.DeserializeObject<RootObject>(content); // Byt ut till er eget huvudobjekt
            

            foreach (Laureate l in menu.laureates) //går igenom varje person i Lauratelistan
            {
                if(l.bornCountry == "Sweden") //Om personen är ifrån Sverige så skrivs det ut
                {
                    Console.WriteLine(l.firstname + " " + l.surname);
                    Console.WriteLine(l.died);
                    Console.WriteLine(l.prizes [0].category);
                    Console.WriteLine(l.prizes[0].year);
                }

            }
            
            Console.Read();
        }

    }
}
