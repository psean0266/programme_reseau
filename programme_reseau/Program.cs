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
          //  string url = "https://codeavecjonathan.com/res/pizzas1.Json";
            // string url = "https://codeavec jonathan.com/res/pizzasssssssssss1.Json";
            //  string url = "https://codeavec_jonathan.com/res/pizzas1.Json";
            string url = "https://codeavecjonathan.com/res/papillon.jpg";

            var  webClient = new WebClient();
          

          Console.WriteLine("Acces au reseau");
        

            try
            {
                // string reponse = webClient.DownloadString(url); /// pour copier le string
                webClient.DownloadFile(url, "papillon.jpg"); /// pour copier les fichiers
                //  Console.WriteLine(reponse);
                Console.WriteLine("Téléchargement terminer");
            }
            catch (WebException ex)
            {       
                if(ex.Response != null) {

                    var statusCode = ((HttpWebResponse)ex.Response).StatusCode;

                    if (statusCode == HttpStatusCode.NotFound)
                    {
                        Console.WriteLine("ERREUR RESEAU : Non trouvé ");
                    }
                    else
                    {
                        Console.WriteLine(" ERREUR RESEAU : " + statusCode);
                    }

                }

                else
                {
                    Console.WriteLine(" ERREUR RESEAU : " + ex.Message);
                }


            }


        }
    }
}
