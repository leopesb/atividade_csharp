using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpClientSample
{
    class Program
    {   
        private static void Main(string[] args)
        {
           GetAsync(client).Wait();
        }

        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
        };

        private static async Task GetAsync (HttpClient httpClient)
        {
            using HttpResponseMessage response = await httpClient.GetAsync("todos/3");

            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine($"{jsonResponse}\n");
        }
    }
}