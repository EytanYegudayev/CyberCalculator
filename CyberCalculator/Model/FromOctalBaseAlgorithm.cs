using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class FromOctalBaseAlgorithm : FromBaseAlgorithm
    {
        public static readonly string ALGORITHM_NAME = "FromOctal";
        public FromOctalBaseAlgorithm() : base(8)
        {
        }
    }
}
