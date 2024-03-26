﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CyberCalculator.Model
{
    public class CyberCalc
    {
        public List<ICryptoFunction> CryptoFunctions = new List<ICryptoFunction>();

        public string Compute(string stringInput)
        {
            string stringOutput = stringInput;
            byte[] byteOutput = Encoding.UTF8.GetBytes(stringInput);
            foreach (ICryptoFunction function in CryptoFunctions)
            {
                stringOutput = function.ComputeAlogrithm(stringOutput);
            }
            return stringOutput;
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
