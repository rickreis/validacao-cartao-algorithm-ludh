using System;
using System.Linq;

namespace Leanwork.ValidCredCard
{
    public class ValidateCredCard
    {
        public bool IsValid(string number)
        {
            if (String.IsNullOrWhiteSpace(number))
            {
                return false;
            }

            if (number.StartsWith("4")
                || number.StartsWith("34")
                || number.StartsWith("37")
                || number.StartsWith("6011")
                || number.StartsWith("51")
                || number.StartsWith("52")
                || number.StartsWith("53")
                || number.StartsWith("54")
                || number.StartsWith("55"))
            {
                return CheckSum(number);
            }

            return false;
        }

        /// <summary>
        /// Check number algorithm luhn
        /// </summary>
        /// <param name="number">number credcard</param>
        /// <returns>return is valid</returns>
        bool CheckSum(string number)
        {
            //validação para número do cartão inválido
            if (String.IsNullOrWhiteSpace(number))
                return false;

            int checkSum = number.Where((e) => e >= '0' && e <= '9')
                    .Reverse()
                    .Select((e, i) => ((int)e - 48) * (i % 2 == 0 ? 1 : 2))
                    .Sum((e) => e / 10 + e % 10);

            //verificamos se a váriavel "checksum" tem o valor de módulo 10 válido
            return checkSum % 10 == 0;
        }
    }
}
