using System.Net.Http;

namespace RazorPayIfscApi
{
    public class RazorPayIfsc
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://ifsc.razorpay.com";
        public RazorPayIfsc()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetIfscInfo(string Ifsc)
        {
            var response = await httpClient.GetAsync($"{apiUrl}/{Ifsc}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
