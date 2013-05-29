using System.Net;
using System.Net.Http;

namespace SimpleAsyncClient
{
    public class CompressedHttpClient : HttpClient
    {
        public CompressedHttpClient() : base(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip }) {}
    }
}