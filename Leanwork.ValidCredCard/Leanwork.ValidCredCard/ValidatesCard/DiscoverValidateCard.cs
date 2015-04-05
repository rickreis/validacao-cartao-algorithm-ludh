using System;

namespace Leanwork.ValidCredCard
{
    internal class DiscoverValidateCard : IValidateCredCard
    {
        public bool IsValid(string number)
        {
            if (String.IsNullOrWhiteSpace(number) || number.StartsWith("6011") == false || number.Length != 16)
            {
                return false;
            }

            return ValidNumberAlgorithmLuhn.IsValid(number);
        }
    }
}
