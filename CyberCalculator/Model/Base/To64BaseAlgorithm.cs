using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class To64BaseAlgorithm : ToBaseAlgorithm
    {
        public const string ALGORITHM_NAME = "To64Base";
        public To64BaseAlgorithm() : base(64, -1)
        {
        }

        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            string stringOutput = Convert.ToBase64String(bytesInput);
            return Encoding.UTF8.GetBytes(stringOutput);
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
