using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web_Page_Downloader
{
    class Program
    {
        private readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
        }

        async Task Scrapper()
        {
            Console.WriteLine("Enter URL: ");
            string url = Console.ReadLine();
            try
            {
                var responseString = await client.GetStringAsync(url);
                Console.WriteLine("Enter the path to save the file. Example E:\tmp\test.txt");
                string path = Console.ReadLine();
                await File.WriteAllTextAsync(path, responseString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
