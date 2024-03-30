using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class FromHexBaseAlgorithm : FromBaseAlgorithm
    {
        public const string ALGORITHM_NAME = "FromHex";
        public FromHexBaseAlgorithm() : base(16, 2)
        {
        }
        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
