using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class SHA256Algorithm : ICryptoFunction
    {
        public static readonly string ALGORITHM_NAME = "SHA256";
        public SHA256Algorithm()
        {
        }

        public string ComputeAlogrithm(string stringInput)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            // reutrn the 
            return BitConverter.ToString(ComputeAlogrithm(bytes)).Replace("-", " ");
        }

        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            SHA256 sha256= SHA256.Create();
            return sha256.ComputeHash(bytesInput);
        }
    }
}
