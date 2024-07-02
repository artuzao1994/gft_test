using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Questao2.Service
{
    internal class FootballScoreService
    {
        public const string ApiUrl = "https://jsonmock.hackerrank.com/api/football_matches";

        public int Get(string team, int year)
        {
            string getParams = "?year=" + year + "&team1=" + team;
            string result;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ApiUrl + getParams);
                     
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                result =  reader.ReadToEnd();                
            }
            return JsonConvert.DeserializeObject<TeamResult>(result).Total;
            
        }

    }
}
