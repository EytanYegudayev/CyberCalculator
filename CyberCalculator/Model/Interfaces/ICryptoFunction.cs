using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public interface ICryptoFunction
    {
        string ComputeAlogrithm(string stringInput);
        byte[] ComputeAlogrithm(byte[] bytesInput);
    }
}
