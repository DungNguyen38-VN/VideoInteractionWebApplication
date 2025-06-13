using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.API
{
    public static class SignatureHelper
    {
        public static string BuildSign(string method, string path, string appSecret, string appKey, string timestamp)
        {
            string canonicalString = $"{method}\n{path}\n{timestamp}\n{appKey}";
            var encoding = Encoding.UTF8;
            var keyBytes = encoding.GetBytes(appSecret);
            var valueBytes = encoding.GetBytes(canonicalString);

            using (var hmac = new HMACSHA256(keyBytes))
            {
                var hashBytes = hmac.ComputeHash(valueBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static string GenerateSignature(string appSecret, string method, string path, string body, string timestamp)
        {
            string httpMethod = method.ToUpperInvariant();

            string accept = "application/json";
            string contentType = "application/json; charset=utf-8";
            string contentMd5 = "";  // bỏ trống nếu không tính
            string date = "";        // bỏ trống nếu không dùng

            // CanonicalizedHeaders: các header bắt đầu bằng x-ca- cần đưa vào đây
            string canonicalizedHeaders = $"x-ca-key:{HikvisionConfig.AppKey}\nx-ca-timestamp:{timestamp}";

            // CanonicalizedResource: là path, ví dụ: /artemis/api/tvms/v1/tvwall/scenes
            string canonicalizedResource = path;

            string stringToSign = $"{httpMethod}\n{accept}\n{contentMd5}\n{contentType}\n{date}\n{canonicalizedHeaders}\n{canonicalizedResource}";

            // Tạo chữ ký bằng HMAC-SHA256
            using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(appSecret));
            byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(stringToSign));
            return Convert.ToBase64String(hashBytes);
        }

    }

}
