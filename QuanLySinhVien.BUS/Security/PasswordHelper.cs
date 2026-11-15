
using System;
using System.Security.Cryptography;

namespace QuanLySinhVien.BUS.Security
{
    public static class PasswordHelper
    {
        private const int SoLanLap = 100000;
        private const int DoDaiSalt = 16;
        private const int DoDaiHash = 32;

        // Băm mật khẩu trước khi lưu
        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(DoDaiSalt);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                SoLanLap,
                HashAlgorithmName.SHA256,
                DoDaiHash);

            return Convert.ToBase64String(salt)
                   + "."
                   + Convert.ToBase64String(hash);
        }

        // Kiểm tra mật khẩu nhập vào
        public static bool VerifyPassword(
            string password,
            string passwordHash)
        {
            try
            {
                string[] parts = passwordHash.Split('.');

                if (parts.Length != 2)
                    return false;

                byte[] salt = Convert.FromBase64String(parts[0]);
                byte[] hashCu = Convert.FromBase64String(parts[1]);

                byte[] hashMoi = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    SoLanLap,
                    HashAlgorithmName.SHA256,
                    DoDaiHash);

                return CryptographicOperations.FixedTimeEquals(
                    hashCu,
                    hashMoi);
            }
            catch
            {
                return false;
            }
        }
    }
}
