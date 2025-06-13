using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace VideoInteraction.API
{
    public class TvWallApiCaller
    {
        public async Task CallTvWallApiAsync()
        {
            // Bypass HTTPS certificate warning (development only)
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;

            string path = "/artemis/api/tvms/v1/tvwall/allResources";
            string fullUrl = $"{HikvisionConfig.BaseUrl}{path}";
            string method = "POST";
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            string signature = SignatureHelper.BuildSign(method, path, HikvisionConfig.AppSecret, HikvisionConfig.AppKey, timestamp);

            var client = new RestClient(fullUrl);
            var request = new RestRequest("", Method.Post);

            // Headers required by Hikvision Artemis platform
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("X-Ca-Key", HikvisionConfig.AppKey);
            request.AddHeader("X-Ca-Timestamp", timestamp);
            request.AddHeader("X-Ca-Signature", signature);
            request.AddHeader("X-Ca-Signature-Headers", "X-Ca-Key,X-Ca-Timestamp");

            // Optional: Add body if needed (e.g., paging, filters)
            var body = new { }; // if body is required, provide it here
            string jsonBody = JsonConvert.SerializeObject(body);
            request.AddStringBody(jsonBody, DataFormat.Json);

            var response = await client.ExecuteAsync(request);

            Console.WriteLine("Status Code: " + response.StatusCode);
            Console.WriteLine("Response: " + response.Content);
        }
        public async Task<string> GetTvWallScenesAsync()
        {
            string apiPath = "/artemis/api/tvms/v1/tvwall/scenes";
            string url = HikvisionConfig.BaseUrl + apiPath;
            string method = "POST";
            string body = "{}"; // nếu API không yêu cầu tham số

            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string signature = SignatureHelper.GenerateSignature(HikvisionConfig.AppSecret, method, apiPath, body, timestamp);

            using var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(body, Encoding.UTF8, "application/json")
            };

            // Thêm các header xác thực
            request.Headers.Add("x-Ca-Key", HikvisionConfig.AppKey);
            request.Headers.Add("x-Ca-Timestamp", timestamp);
            request.Headers.Add("x-Ca-Signature", signature);
            request.Headers.Add("x-Ca-Signature-Headers", "x-Ca-Key,x-Ca-Timestamp");

            // Bỏ qua SSL nếu bạn dùng chứng chỉ tự ký (chỉ nên dùng trong dev)
            var handler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var customClient = new HttpClient(handler);
            var response = await customClient.SendAsync(request);

            string jsonResult = await response.Content.ReadAsStringAsync();
            return jsonResult;
        }

    }

}
