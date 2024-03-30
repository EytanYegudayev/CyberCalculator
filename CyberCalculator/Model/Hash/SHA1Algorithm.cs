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
        public const string ALGORITHM_NAME = "SHA1";
        public SHA1Algorithm()
        {
        }


        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashByte = sha1.ComputeHash(bytesInput);
            return Encoding.UTF8.GetBytes(BitConverter.ToString(hashByte).Replace("-", "").ToLower());
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
