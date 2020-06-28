using System;
using RestSharp;

namespace prob
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://127.0.0.1:5000/");
            var request = new RestRequest("predict/slice", Method.POST, DataFormat.Json);

            request.AddJsonBody(new PredictRequest { seed = 1, requestPorosity = 0.45f, slice = 1 });

            var response = client.Execute(request);
        }
    }
    class PredictRequest
    {
        public int seed;
        public float requestPorosity;
        public int slice;
    }
}
