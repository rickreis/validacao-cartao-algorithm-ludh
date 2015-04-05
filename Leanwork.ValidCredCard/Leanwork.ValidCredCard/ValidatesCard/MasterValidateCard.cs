using System;

namespace Leanwork.ValidCredCard
{
    internal class MasterValidateCard : IValidateCredidCard
    {
        public bool IsValid(string number)
        {
            if (String.IsNullOrWhiteSpace(number) || number.Length != 16)
            {
                return false;
            }

            if (number.StartsWith("51") 
                || number.StartsWith("52") 
                || number.StartsWith("53") 
                || number.StartsWith("54") 
                || number.StartsWith("55"))
            {
                return ValidNumberAlgorithmLuhn.IsValid(number);
            }

            return false;
        }
    }
}
