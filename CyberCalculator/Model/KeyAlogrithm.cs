using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class KeyAlogrithm: ICryptoFunction
    {
        public byte[] Key { get; set; }

        public KeyAlogrithm(string key)
        {
            // key must be in hexadecimal representation  -> like this format 52 00 13 05
            string[] hexbytes = key.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Key = hexbytes.Select(b => Convert.ToByte(b, 16)).ToArray();
        }

        public abstract string ComputeAlogrithm(string stringInput);

        public abstract byte[] ComputeAlogrithm(byte[] bytesInput);

    }
}
