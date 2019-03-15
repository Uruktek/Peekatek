using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PeekaTekDesktop
{
    class InfoFromPokeApi
    {
        public string pName { get; set; }
        public string locUrl { get; set; }

        public string Url = "http://pokeapi.co/api/v2/pokemon/";

        public void deserializedData(string url)
        {

            using (WebClient wc = new WebClient())
            {
                string jsonWebData = wc.DownloadString(url);

                dynamic jsonDisplay = JsonConvert.DeserializeObject(jsonWebData);

                pName = jsonDisplay.name;
                locUrl = jsonDisplay.location_area_encounters;


                Console.WriteLine("pName: from inside " + pName);
                Console.WriteLine("locUrl: from inside  " + locUrl);

                
            }
        }

        

    }
}
