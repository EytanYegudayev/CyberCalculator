using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class FromHexBaseAlgorithm : FromBaseAlgorithm
    {
        public static readonly string ALGORITHM_NAME = "FromHex";
        public FromHexBaseAlgorithm() : base(16)
        {
        }
    }
}
