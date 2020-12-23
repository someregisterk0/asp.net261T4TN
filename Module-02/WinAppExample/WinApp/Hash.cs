
using System.Text;
using System.Security.Cryptography;

namespace WinApp
{
    class Hash
    {
        public static byte[] Sha(string pwd)
        {
            //HashAlgorithm hash = SHA512.Create();
            HashAlgorithm hash = HashAlgorithm.Create("SHA-512");
            return hash.ComputeHash(Encoding.ASCII.GetBytes(pwd));
        }
    }
}
