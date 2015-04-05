using System;

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

            number = number.RemoveCharacters(" ", ",", ".", "-", "_");

            IValidateCredCard valid = null;

            if (number.StartsWith("4"))
            {
                valid = new VisaValidateCard();                
            }
            else if (number.StartsWith("34") || number.StartsWith("37"))
            {
                valid = new AmexValidateCard();                
            }
            else if (number.StartsWith("6011"))
            {
                valid = new DiscoverValidateCard();                
            }
            else if (number.StartsWith("5"))
            {
                valid = new MasterValidateCard();
            }            

            if(valid == null)
            {
                return false;
            }

            return valid.IsValid(number);
        }
    }
}
