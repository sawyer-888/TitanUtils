using System.Net.Http;
using System.Threading.Tasks;

namespace TitanUtilsLib.Utils
{
    public static class NetUtils
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> GetRequestAsync(string url) => await client.GetStringAsync(url);

        public static async Task<string> PostRequestAsync(string url, HttpContent content)
        {
            var response = await client.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
