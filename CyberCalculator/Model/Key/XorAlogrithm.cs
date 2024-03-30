using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class XorAlogrithm: KeyAlogrithm
    {
        public const string ALGORITHM_NAME = "XOR";
        public XorAlogrithm(string key) : base(key)
        {
        }
        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            // compute the bytes input XOR key
            byte[] output = new byte[bytesInput.Length];
            for (int i = 0; i < bytesInput.Length; i++)
            {
                output[i] = (byte)(bytesInput[i] ^ Key[i % Key.Length]);
            }
            return output;
        }

        public override string ToString()
        {
            return ALGORITHM_NAME + " " + base.ToString();
        }
    }
}
