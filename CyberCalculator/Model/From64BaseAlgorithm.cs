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
        public From64BaseAlgorithm() : base(64)
        {
        }

        public override string ComputeAlogrithm(string stringInput)
        { 
            byte[] bytes = Convert.FromBase64String(stringInput);
            return Encoding.UTF8.GetString(bytes);
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
