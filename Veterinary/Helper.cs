using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Veterinary
{
    public class Helper
    {
        public static string PassSecret = "eefa52892947103b4fb36c460c878dd58483b8aad2a439b2d1eb51a8bc1fb513";

        static public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private static Random random = new Random();
        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 32)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        internal static string ComputeSha256Hash(object p)
        {
            throw new NotImplementedException();
        }
    }
}