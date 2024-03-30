using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCalculator.Model
{
    public abstract class BaseAlgorithm : ICryptoFunction
    {
        private readonly int _baseNumber;
        private readonly int _paddingNumber;
        public BaseAlgorithm(int baseNumber, int paddingNumber)
        {
            _baseNumber = baseNumber;
            _paddingNumber = paddingNumber;
        }

        public int getBaseNumber() => _baseNumber;

        public int getPaddingNumber() => _paddingNumber;    
        public abstract byte[] ComputeAlogrithm(byte[] bytesInput);
    }
}
