using System;

namespace Leanwork.ValidCredCard
{
    internal class AmexValidateCard : IValidateCredCard
    {
        public bool IsValid(string number)
        {
            if (String.IsNullOrWhiteSpace(number) || number.Length != 15)
            {
                return false;
            }

            if (number.StartsWith("34") || number.StartsWith("37"))
            {
                return ValidNumberAlgorithmLuhn.IsValid(number);
            }

            return false;
        }
    }
}
