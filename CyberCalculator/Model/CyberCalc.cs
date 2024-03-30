using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CyberCalculator.Model
{
    public class CyberCalc
    {
        public List<ICryptoFunction> CryptoFunctions = new List<ICryptoFunction>();


        public byte[] Compute(byte[] bytesInput) 
        {

            byte[] bytesOutput =  bytesInput;

            foreach(ICryptoFunction cryptoFunction in CryptoFunctions)
            {
                bytesOutput = cryptoFunction.ComputeAlogrithm(bytesOutput);
            }
            return bytesOutput;
        }

        public void AddCryptoFunction(ICryptoFunction cryptoFunction) {
            CryptoFunctions.Add(cryptoFunction);
        }

        public void ResetCyberCalculator()
        {
            CryptoFunctions.RemoveAll(f => true);
        }

        public void RemoveLastCryptoFunction()
        {
            CryptoFunctions.RemoveAt(CryptoFunctions.Count - 1);
        }




    }
}
