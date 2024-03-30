using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class FromBaseAlgorithm : BaseAlgorithm
    {
        public FromBaseAlgorithm(int baseNumber, int paddingNumber) : base(baseNumber, paddingNumber)
        {
        }

        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            // The input must be in row -> 1010101110101011.... OR FFDD11DDFF (without special cahrs) 
            string stringInput = Encoding.UTF8.GetString(bytesInput);
            List<byte> bytesOutpue = new List<byte>();
            for (int i = 0; i < stringInput.Length; i += getPaddingNumber())
            {
                string subString = stringInput.Substring(i);
                if (subString.Length > getPaddingNumber())
                    subString = subString.Substring(0, getPaddingNumber());
                
                bytesOutpue.Add(Convert.ToByte(subString, getBaseNumber()));
            }
            return bytesOutpue.ToArray();
        }
    }
}
