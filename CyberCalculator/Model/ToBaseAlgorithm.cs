using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class ToBaseAlgorithm : BaseAlgorithm
    {
        private readonly int _numberOfPadding;
        public ToBaseAlgorithm(int baseNumber, int numberOfPadding) : base(baseNumber)
        {
            _numberOfPadding = numberOfPadding;
        }

        public override string ComputeAlogrithm(string stringInput)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            string output = String.Join(" ", bytes.Select(b => Convert.ToString(b, getBaseNumber()).PadLeft(_numberOfPadding, '0')).ToArray());
            return output;
        }
        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            return bytesInput;
        }

        
    }
}
