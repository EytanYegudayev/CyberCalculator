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

        public string ComputeAlogrithm(string stringInput)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            return BitConverter.ToString(ComputeAlogrithm(bytes)).Replace("-", " ");
        }

        public byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(bytesInput);
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
