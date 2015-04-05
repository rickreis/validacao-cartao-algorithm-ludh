using System;

namespace Leanwork.ValidCredCard
{
    internal class VisaValidateCard : IValidateCredidCard
    {
        public bool IsValid(string number)
        {
            if (String.IsNullOrWhiteSpace(number) || number.StartsWith("4") == false)
            {
                return false;
            }

            if ((number.Length == 13 || number.Length == 16) == false)
            {
                return false;
            }

            return ValidNumberAlgorithmLuhn.IsValid(number);
        }
    }
}
