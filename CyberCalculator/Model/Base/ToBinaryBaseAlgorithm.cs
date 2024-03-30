using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class ToBinaryBaseAlgorithm : ToBaseAlgorithm
    {
        public const string ALGORITHM_NAME = "ToBinary";
        public ToBinaryBaseAlgorithm() : base(2, 8)
        {
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
