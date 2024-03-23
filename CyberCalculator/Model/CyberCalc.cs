using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CyberCalculator.Model
{
    public class CyberCalc
    {
        public readonly Encoding encoding437 = Encoding.GetEncoding(437);
        public static string[] FUNCTION_NAMES_ARRAY =  
         {
            "FromHex", "ToHex", 
            "FromBinary", "ToBinary",
            "FromOctal", "ToOctal",
            "FromDecimal", "ToDecimal",
            "FromBase64", "ToBase64",
            "Sha1", "Sha256",
            "Md5", "XOR", "AND"
        };

        public string Compute(string stringInput, string recipe, byte[] bytesInput)
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
                            output = ToHex(Encoding.UTF8.GetBytes(stringInput));
                            break;
                        case "FromHex":
                            output = FromHex(stringInput);
                            break;
                        case "ToBinary":
                            output = ToBinary(Encoding.UTF8.GetBytes(stringInput));
                            break;
                        case "FromBinary":
                            output = FromBinary(stringInput);
                            break;
                        case "ToOctal":
                            output = ToOctal(Encoding.UTF8.GetBytes(stringInput));
                            break;
                        case "FromOctal":
                            output = FromOctal(stringInput);
                            break;
                        case "ToDecimal":
                            output = ToDecimal(Encoding.UTF8.GetBytes(stringInput));
                            break;
                        case "FromDecimal":
                            output = FromDecimal(stringInput);
                            break;
                        case "Sha1":
                            output = ToSha1(bytesInput);
                            break;
                        case "Sha256":
                            output = ToSha256(bytesInput);
                            break;
                        case "ToBase64":
                            output = ToBase64(Encoding.UTF8.GetBytes(stringInput));
                            break;
                        case "FromBase64":
                            output = FromBase64(stringInput);
                            break;
                        case "Md5":
                            output = ToMd5(bytesInput);
                            break;
                        case "XOR":
                            output = XOR(bytesInput);
                            break;
                        case "AND":
                            output = AND(bytesInput);
                            break;
                        default:
                            break;

                    }
                    stringInput = output;
                    bytesInput = encoding437.GetBytes(stringInput);
                }
            }
            catch 
            {
                return null;
            }
            return output;
        }

        private string XOR(byte[] bytesInput)
        { 
            return "";
        }

        private string AND(byte[] bytesInput) 
        {
            return "";
        }
        private string ToHex(byte[] bytes)
        {
            return ToBaseX(16, bytes, 2);
        }

        private string FromHex(string s)
        {
            return FromBaseX(16, s);
        }

        private string ToBinary(byte[] bytes)
        {
            return ToBaseX(2, bytes, 8);
        }

        private string FromBinary(string s)
        {

            return FromBaseX(2, s);

        }
        private string ToOctal(byte[] bytes)
        {
            return ToBaseX(8, bytes, 3);
        }

        private string FromOctal(string s)
        {
            return FromBaseX(8, s);

        }

        private string ToDecimal(byte[] bytes)
        {
            return ToBaseX(10, bytes, 3);
        }
        private string FromDecimal(string s)
        {
            return FromBaseX(10, s);
        }

        private string ToBase64(byte[]bytesInput)
        {
            return Convert.ToBase64String(bytesInput);
        }
        private string FromBase64(string s)
        {
            byte[] bytes = Convert.FromBase64String(s);
            return encoding437.GetString(bytes);
        }

        private string ToSha1(byte[] bytesInput)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytesInput);
            return BitConverter.ToString(hashBytes).Replace("-", " ");
        }

        private string ToSha256(byte[] bytesInput)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(bytesInput);
            return BitConverter.ToString(hashBytes).Replace("-", " ");
        }

        private string ToMd5(byte[] bytesInput)
        {
            MD5 md5 = MD5.Create();
            byte[] hashBytes = md5.ComputeHash(bytesInput);
            return BitConverter.ToString(hashBytes).Replace('-', ' ');
        }

        private string FromBaseX(int baseX, string stringInput)
        {
            string[] binaryBytes = stringInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            byte[] bytes = binaryBytes.Select(b=> Convert.ToByte(b, baseX)).ToArray();
            return encoding437.GetString(bytes);
        }

        private string ToBaseX(int baseX, byte[] bytes, int padLef)
        {
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
