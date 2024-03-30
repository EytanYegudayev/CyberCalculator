using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class MD5Algorithm : ICryptoFunction
    {
        public const string ALGORITHM_NAME = "MD5";
        public MD5Algorithm()
        {

        }

        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            MD5 md5 = MD5.Create();
            byte[] hashByte = md5.ComputeHash(bytesInput);
            return Encoding.UTF8.GetBytes(BitConverter.ToString(hashByte).Replace("-", "").ToLower());
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
