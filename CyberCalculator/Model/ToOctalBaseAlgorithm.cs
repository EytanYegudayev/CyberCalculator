using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public class ToOctalBaseAlgorithm : ToBaseAlgorithm    {
        public static readonly string ALGORITHM_NAME = "ToOctal";
        public ToOctalBaseAlgorithm() : base(8, 3)
        {
        }
    }
}
