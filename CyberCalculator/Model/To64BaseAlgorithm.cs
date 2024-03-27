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

        public override string ComputeAlogrithm(string stringInput)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(stringInput);
            return Convert.ToBase64String(bytes);
        }

        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            return bytesInput;
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
