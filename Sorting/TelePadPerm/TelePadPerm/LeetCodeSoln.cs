using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelePadPerm
{
    class LeetCodeSoln
    {
        List<string> TeleValues = new List<string>() { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
        public List<string> GetPerm(string digits)
        {
            List<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))
                return result;

            Combination("", digits, 0, result);

            return result;
            
        }

        private void Combination(string prefix, string digits, int offset, List<string> result)
        {
            if (offset >= digits.Length)
            {
                result.Add(prefix);
            }
            else
            {
                string digitsChar = TeleValues[digits[offset]-'0'];
                foreach (char chr in digitsChar)
                {
                    Combination(prefix + chr, digits, offset + 1, result);
                }
            }
        }
    }
}
