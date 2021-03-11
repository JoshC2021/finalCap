using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace testingCarAPICap.Models
{
    public class CarDAL
    {
        public string GetData()
        {
            //URL can be different based upon endpoint/API 
            string url = "https://localhost:44354/api/Cars";

            //Web Requests sometimes need Headers/User Agent prop
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = null;

            response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd();
            return json;
        }

        public List<Car> ReturnAll()
        {
            string json = GetData();

            List<Car> c = JsonConvert.DeserializeObject<List<Car>>(json);   
            return c;
        }

        public string Search(string option, string param)
        {
            //URL can be different based upon endpoint/API 
            string url = $"https://localhost:44354/api/Cars/{option}/{param}";

            //Web Requests sometimes need Headers/User Agent prop
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = null;

            response = (HttpWebResponse)request.GetResponse();
            StreamReader rd = new StreamReader(response.GetResponseStream());
            string json = rd.ReadToEnd();
            return json;
        }

        public List<Car> ReturnSearch(string option, string param)
        {
            string json = Search(option, param);

            List<Car> c = JsonConvert.DeserializeObject<List<Car>>(json);
            return c;
        }
    }
}
