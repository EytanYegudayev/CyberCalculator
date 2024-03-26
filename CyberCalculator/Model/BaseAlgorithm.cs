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
        public BaseAlgorithm(int baseNumber)
        {
            _baseNumber = baseNumber;
        }

        public int getBaseNumber() => _baseNumber;

        public abstract string ComputeAlogrithm(string stringInput);

        public abstract byte[] ComputeAlogrithm(byte[] bytesInput);
    }
}
