using System.Text;
using System.Security.Cryptography;

namespace Protego.Core.Utilities
{
    public class PasswordUtilities
    {
        public static (byte[], string) HashPassword(string password)
        {
            string salt = GenerateSalt();

            byte[] passwordHash = SHA256.HashData(Encoding.UTF8.GetBytes(password + salt));

            return (passwordHash, salt);
        }

        private static string GenerateSalt()
        {
            using RandomNumberGenerator generator = RandomNumberGenerator.Create();

            byte[] saltBytes = new byte[8];
            generator.GetBytes(saltBytes);

            return Convert.ToHexStringLower(saltBytes);
        }
    }
}