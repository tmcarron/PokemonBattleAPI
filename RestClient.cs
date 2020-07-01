using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    class RestClient
    {
        public enum httpVerb
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = "";
            httpMethod = httpVerb.GET;
        }
        public string makeRequest()
        {
            string strOutput = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Method = httpMethod.ToString();

            using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {


                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code:"+response.StatusCode.ToString());
                }


                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream != null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strOutput = reader.ReadToEnd();
                        }

                    }

                }



            }
            return strOutput;
        }
    }
}
