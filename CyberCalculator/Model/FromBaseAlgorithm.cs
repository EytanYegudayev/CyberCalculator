using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class FromBaseAlgorithm : BaseAlgorithm
    {
        public FromBaseAlgorithm(int baseNumber) : base(baseNumber)
        {
        }

        public override string ComputeAlogrithm(string stringInput)
        {
            string[] binaryBytes = stringInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = binaryBytes.Select(b => Convert.ToByte(b, getBaseNumber())).ToArray();
            return Encoding.UTF8.GetString(bytes);
        }
        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            return bytesInput;
        }
    }
}
