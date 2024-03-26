using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class SHA1Algorithm : ICryptoFunction
    {
        public static readonly string ALGORITHM_NAME = "SHA1";
        public SHA1Algorithm()
        {
        }

        public string ComputeAlogrithm(string stringInput)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            return BitConverter.ToString(ComputeAlogrithm(bytes)).Replace("-", " ");
        }

        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(bytesInput);
        }
    }
}
