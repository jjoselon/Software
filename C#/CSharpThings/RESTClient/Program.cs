using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;

namespace RESTClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            getAllHeroes().Wait();
            Console.ReadKey();
        }
        
        private static async Task getAllHeroes()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json")    
            );
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var stringTask = await client.GetStreamAsync("https://raw.githubusercontent.com/jjoselon/Software/master/JavaScript/heroes.json");
            var serializer = new DataContractJsonSerializer(typeof(Heroes));
            var heroes = serializer.ReadObject(stringTask) as Heroes;

            foreach (var member in heroes.members)
            {
                Console.Write($"{member.name}: ");

                foreach (var powerName in member.powers)
                {
                    Console.Write($"{powerName}");
                }

                Console.WriteLine("");

            }
        }
        
    }
}
