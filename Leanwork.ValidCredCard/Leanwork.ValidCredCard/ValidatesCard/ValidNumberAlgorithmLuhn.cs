using System;
using System.Linq;

namespace Leanwork.ValidCredCard
{
    internal static class ValidNumberAlgorithmLuhn
    {
        internal static bool IsValid(string number)
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

        /// <summary>
        /// Somente para exemplo, sem o uso de Linq
        /// </summary>
        /// <param name="number">Número cartão</param>
        /// <returns>retrona o valor do checksum</returns>
        static decimal GetCheckSum(string number)
        {
            //criamos um array dos números e invertemos para que o algoritmo Luhn seja realizado
            var numbersReverse = number.Reverse().ToArray();

            decimal checkSum = Decimal.Zero;

            for (int i = 0; i < numbersReverse.Length; i++)
            {
                decimal value = Decimal.Zero;

                //convertemos o valor da posição do array para decimal
                Decimal.TryParse(numbersReverse[i].ToString(), out value);

                // verificamos se "i" tem a posição impar do array
                if (i % 2 != 0)
                {
                    //multiplicamos o valor da posição i do array em dobro
                    value *= 2;

                    //verificamos se o valor é maior que 9
                    if (value > 9)
                        value -= 9;
                }

                //somamos o valor para checagem da varíavel "checksum"
                checkSum += value;
            }

            return checkSum;
        }
    }
}
