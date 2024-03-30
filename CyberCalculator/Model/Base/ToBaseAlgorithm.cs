using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class ToBaseAlgorithm : BaseAlgorithm
    {
        public ToBaseAlgorithm(int baseNumber, int numberOfPadding) : base(baseNumber, numberOfPadding)
        {
        }
        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            string stringOutput = String.Join("", bytesInput.Select(b => Convert.ToString(b, getBaseNumber()).PadLeft(getPaddingNumber(), '0')).ToArray()); 
            return Encoding.UTF8.GetBytes(stringOutput);
        }

        
    }
}
