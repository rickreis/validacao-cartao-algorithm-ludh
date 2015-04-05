using System;
using System.Linq;

namespace Leanwork.ValidCredCard
{
    internal static class ValidNumberAlgorithmLuhn
    {
        internal static bool IsValid(string number)
        {
            //validação para número do cartão inválido
            if(String.IsNullOrWhiteSpace(number))            
                return false;            

            //criamos um array dos números e invertemos para que o algoritmo Luhn seja realizado
            var numbersReverse = number.Reverse().ToArray();

            decimal checkSum = Decimal.Zero;

            for (int i = 0; i < numbersReverse.Length; i++)
            {
                decimal value = Decimal.Zero;

                //convertemos o valor da posição do array para decimal
                Decimal.TryParse(numbersReverse[i].ToString(), out value);                

                // verificamos se "i" tem a posição impar do array
                if(i % 2 != 0)
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

            //verificamos se a váriavel "checksum" tem o valor de módulo 10 válido
            return checkSum % 10 == 0;
        }
    }
}
