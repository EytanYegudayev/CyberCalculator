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
        public static readonly string ALGORITHM_NAME = "XOR";
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

        public override string ComputeAlogrithm(string stringInput)
        {
            // Input string is in UTF 8 representation
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            // Use the function above and convert the bytes to string
            return Encoding.UTF8.GetString(ComputeAlogrithm(bytes));
        }
    }
}
