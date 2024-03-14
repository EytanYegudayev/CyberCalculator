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
                            break;
                        case "FromBase64":
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
            byte[] ba = Encoding.ASCII.GetBytes(s);
            // BitConvertor.ToString function 
            // converts the numeric value of each element of a specified array of bytes to its equivalent hexadecimal string representation.
            return BitConverter.ToString(ba).Replace("-", " ");
        }

        private string FromHex(string s)
        {
            byte[] bytes = s.Split(' ').Select(b => Convert.ToByte(b, 16)).ToArray();
            return Encoding.ASCII.GetString(bytes);
        }

        private string ToBinary(string s)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {   
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0') + " ");
            };
            sb.Length--; // remove the last cahr ' ' ;
            return sb.ToString();
        }

        private string FromBinary(string s)
        {
            
            string[] binaryBytes = s.Split(' ');
            return new string(binaryBytes.Select(b => (char)Convert.ToByte(b, 2)).ToArray());

        }
        private string ToOctal(string s)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(s);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                sb.Append(Convert.ToString(b, 8) + " ");
            }
            sb.Length--;
            return sb.ToString();
        }

        private string FromOctal(string s)
        {
            string[] binaryBytes = s.Split(' ');
            return new string(binaryBytes.Select(b => (char)Convert.ToByte(b, 8)).ToArray());

        }

        private string ToDecimal(string s)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in s)
            {
                stringBuilder.Append((int)c + " ");
            }
            return stringBuilder.ToString();
        }
        private string FromDecimal(string s)
        {
            string[] bytes = s.Split(' ');

            StringBuilder stringBuilder = new StringBuilder();
            foreach (string b in bytes)
            {
                if (b != "")
                    stringBuilder.Append((char)Int32.Parse(b));
            }
            return stringBuilder.ToString();
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


    }
}
