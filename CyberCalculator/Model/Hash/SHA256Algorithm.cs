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
        public const string ALGORITHM_NAME = "SHA256";
        public SHA256Algorithm()
        {
        }

        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashByte = sha256.ComputeHash(bytesInput);
            return Encoding.UTF8.GetBytes(BitConverter.ToString(hashByte).Replace("-", "").ToLower());
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
