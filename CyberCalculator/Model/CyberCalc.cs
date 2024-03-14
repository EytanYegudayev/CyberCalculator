using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CyberCalculator.Model
{
    public class CyberCalc
    {
        public static string[] FUNCTION_NAMES_ARRAY =  
         {
            "FromHex", "ToHex", 
            "FromBinary", "ToBinary",
            "FromOctal", "ToOctal",
            "FromDecimal", "ToDecimal",
            "FromBase64", "ToBase64",
            "Sha1", "Sha256",
        };

        public string Compute(string input, string recipe)
        {
            string output = "";
            string[] recipeArr = recipe.Split('\n');
            recipeArr = recipeArr.Select(s => s.Replace("\r", "")).ToArray();
            StringBuilder outputBuilder = new StringBuilder();
            try
            {

                foreach (string s in recipeArr)
                {

                    switch (s)
                    {
                        case "ToHex":
                            output = ToHex(input);
                            break;
                        case "FromHex":
                            output = FromHex(input);
                            break;
                        case "ToBinary":
                            output = ToBinary(input);
                            break;
                        case "FromBinary":
                            output = FromBinary(input);
                            break;
                        case "ToOctal":
                            output = ToOctal(input);
                            break;
                        case "FromOctal":
                            output = FromOctal(input);
                            break;
                        case "ToDecimal":
                            output = ToDecimal(input);
                            break;
                        case "FromDecimal":
                            output = FromDecimal(input);
                            break;
                        case "Sha1":
                            output = ToSha1(input);
                            break;
                        case "Sha256":
                            output = ToSha256(input);
                            break;
                        case "ToBase64":
                            output = ToBase64(input);
                            break;
                        case "FromBase64":
                            output = FromBase64(input);
                            break;
                        default:
                            break;

                    }
                    input = output;
                }
            }
            catch 
            {
                return null;
            }
            return output;
        }

        private string ToHex(string s)
        {
            return ToBaseX(16, s, 2);
        }

        private string FromHex(string s)
        {
            return FromBaseX(16, s);
        }

        private string ToBinary(string s)
        {
            return ToBaseX(2, s, 8);
        }

        private string FromBinary(string s)
        {

            return FromBaseX(2, s);

        }
        private string ToOctal(string s)
        {
            return ToBaseX(8, s, 3);
        }

        private string FromOctal(string s)
        {
            return FromBaseX(8, s);

        }

        private string ToDecimal(string s)
        {
            return ToBaseX(10, s, 3);
        }
        private string FromDecimal(string s)
        {
            return FromBaseX(10, s);
        }

        private string ToBase64(string s)
        {
            // TODO
            return "";
        }
        private string FromBase64(string s)
        {
            // TODO
            return "";
        }

        private string ToSha1(string s)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(Encoding.ASCII.GetBytes(s));
            return BitConverter.ToString(hashBytes).Replace("-", " ");
        }

        private string ToSha256(string s)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.ASCII.GetBytes(s));
            return BitConverter.ToString(hashBytes).Replace("-", " ");
        }

        private string FromBaseX(int baseX, string s)
        {
            string[] binaryBytes = s.Split(' ');
            return new string(binaryBytes.Select(b => (char)Convert.ToByte(b, baseX)).ToArray());
        }

        private string ToBaseX(int baseX, string s, int padLef)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(Convert.ToString(b, baseX).PadLeft(padLef, '0') + " ");
            }
            sb.Length--;
            return sb.ToString();
        }


    }
}
