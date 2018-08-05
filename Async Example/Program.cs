using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async_Example
{
    class Program
    {
        void Main()
        {
            int contentLength = await AccessTheWebAsynchronously();
            Console.WriteLine($"Length of the downloaded string: {contentLength}");
        }

        async Task<int> AccessTheWebAsynchronously()
        {
            HttpClient client = new HttpClient();
            Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");
            DoIndependentWork();
            string urlContents = await getStringTask;
            return urlContents.Length;

        }

        private void DoIndependentWork()
        {
            Console.WriteLine("Working on it...");
        }
    }
}
