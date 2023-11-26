using System;
using System.Net;

namespace programme_reseau
{
    class Program
    {
        static void Main(string[] args)
        {
            
          string url ="https://codeavecjonathan.com/res/exemple.html" ;
            //   string url = "https://codeavecjonathan.com/res/exemple.txt";
           // string url = "https://codeavecjonathan.com/res/pizza1.Json";


          var  webClient = new WebClient();
          string reponse =  webClient.DownloadString(url);

          Console.WriteLine("Acces au reseau");
          Console.WriteLine(reponse);   


        }
    }
}
