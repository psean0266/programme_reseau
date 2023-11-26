using System;
using System.Net;

namespace programme_reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            
          //string url ="https://codeavecjonathan.com/res/exemple.html" ;
            //   string url = "https://codeavecjonathan.com/res/exemple.txt";
           string url = "https://codeavec jonathan.com/res/pizzasssssssssss1.Json";


          var  webClient = new WebClient();
          

          Console.WriteLine("Acces au reseau");
        

            try
            {
                string reponse = webClient.DownloadString(url);
                Console.WriteLine(reponse);
            }
            catch (WebException ex)
            {
                var statusCode = ((HttpWebResponse)ex.Response).StatusCode;
               

                if (statusCode == HttpStatusCode.NotFound) {
                    Console.WriteLine("ERREUR RESEAU : Non trouvé " );
                }
                else
                {
                    Console.WriteLine(" ERREUR RESEAU : " + statusCode);
                }

            }


        }
    }
}
