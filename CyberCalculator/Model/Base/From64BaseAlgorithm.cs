using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class From64BaseAlgorithm : FromBaseAlgorithm
    {
        public const string ALGORITHM_NAME = "From64Base";
        public From64BaseAlgorithm() : base(64, -1)
        {
        }


        public override byte[] ComputeAlogrithm(byte[] bytesInput)
        {
            byte[] output = Convert.FromBase64String(Encoding.UTF8.GetString(bytesInput));
            return output;
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
