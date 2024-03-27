using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class FromBinaryBaseAlgorithm : FromBaseAlgorithm
    {
        public const string ALGORITHM_NAME = "FromBinary";
        public FromBinaryBaseAlgorithm() : base( 2)
        {
        }

        public override string ToString()
        {
            return ALGORITHM_NAME;
        }
    }
}
