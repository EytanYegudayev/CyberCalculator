using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class ToHexBaseAlogrithm : ToBaseAlgorithm
    {
        public static readonly string ALGORITHM_NAME = "ToHex";
        public ToHexBaseAlogrithm() : base(16, 2)
        {
        }
    }
}
