using System;
using System.Security.Cryptography;
using System.Text;

namespace Application.Extensions
{
    public static class CommonExtension
    {
        public static string md5Key = "*1234567890!@#$%&*14344*Boutiqaat";
        public static string EncryptPass(this string Password)
        {
            try
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                byte[] toEncryptArray = Encoding.UTF8.GetBytes(Password);

                byte[] keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(md5Key));
                hashmd5.Clear();

                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {

                    ICryptoTransform cTransform = tripDes.CreateEncryptor();

                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

                    return Convert.ToBase64String(resultArray, 0, resultArray.Length);
                }
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string DecryptPass(this string Password)
        {
            try
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                byte[] toEncryptArray = Convert.FromBase64String(Password);
                byte[] keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(md5Key));

                hashmd5.Clear();

                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider()
                { Key = keyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform cTransform = tripDes.CreateDecryptor();
                    byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                    tripDes.Clear();

                    return Encoding.UTF8.GetString(resultArray);
                }
            }
            catch
            {
                return string.Empty;
            }
        }



    }
}
