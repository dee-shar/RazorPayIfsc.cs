# RazorPayIfsc.cs
Web-API for [ifsc.razorpay.com](https://ifsc.razorpay.com) API server that serves as Razorpay's IFSC API.

## Example
```cs
using RazorPayIfscApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new RazorPayIfsc();
            string ifscInfo = await api.GetIfscInfo("YESB0DNB002");
            Console.WriteLine(ifscInfo);
        }
    }
}
```
