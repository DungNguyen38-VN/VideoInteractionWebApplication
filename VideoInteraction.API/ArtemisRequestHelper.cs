using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using RestSharp;

namespace VideoInteraction.API
{
    public static class ArtemisRequestHelper
    {

        public static HttpRequestMessage CreateArtemisRequest(string method, string path, string body = "{}")
        {
            string url = HikvisionConfig.BaseUrl + path;
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();

            // Headers cần dùng trong việc ký
            var headersToSign = new Dictionary<string, string>
    {
        { "x-ca-key", HikvisionConfig.AppKey },
        { "x-ca-timestamp", timestamp }
    };

            // Tạo chữ ký
            string signature = SignatureHelper.GenerateSignature(
                  HikvisionConfig.AppSecret,
                  method,
                  path,
                  body,
                  timestamp
              );



            // Tạo HttpRequestMessage
            var request = new HttpRequestMessage(
                new HttpMethod(method), url
            );

            request.Content = new StringContent(body, Encoding.UTF8, "application/json");

            // Thêm headers
            request.Headers.Add("x-ca-key", HikvisionConfig.AppKey);
            request.Headers.Add("x-ca-timestamp", timestamp);
            request.Headers.Add("x-ca-signature", signature);
            request.Headers.Add("x-ca-signature-headers", "x-ca-key,x-ca-timestamp");

            return request;
        }

        public static string GenerateSignature(string appSecret, string method, string path, string body, Dictionary<string, string> headers)
        {
            // Build CanonicalizedHeaders
            var headersToSign = headers
                .Where(h => h.Key.StartsWith("x-ca-"))
                .OrderBy(h => h.Key.ToLower())
                .Select(h => $"{h.Key}:{h.Value}")
                .ToList();

            string canonicalizedHeaders = string.Join("\n", headersToSign);

            // Canonical string to sign
            string stringToSign = $"{method}\napplication/json\n\napplication/json\n\n{canonicalizedHeaders}\n{path}";

            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(appSecret));
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            return Convert.ToBase64String(hashBytes);
        }

        public static RestRequest CreateRestRequest(string method, string path, string body = "{}")
        {
            string timestamp = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString();
            string signature = SignatureHelper.GenerateSignature(
                HikvisionConfig.AppSecret, method, path, body, timestamp);

            var request = new RestRequest("", Method.Post);
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("X-Ca-Key", HikvisionConfig.AppKey);
            request.AddHeader("X-Ca-Timestamp", timestamp);
            request.AddHeader("X-Ca-Signature", signature);
            request.AddHeader("X-Ca-Signature-Headers", "X-Ca-Key,X-Ca-Timestamp");
            request.AddStringBody(body, DataFormat.Json);

            return request;
        }


    }
}
