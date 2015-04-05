using Leanwork.ValidCredCard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lean.ValidCredCard.UTests
{
    [TestClass]
    public class ValidCredCard_Should
    {
        [TestMethod]
        public void Return_invalid_when_number_is_invalid()
        {
            //arrange
            string number = "";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }        

        [TestMethod]
        public void Return_invalid_when_number_less_equal_length_13()
        {
             //arrange
            string number = "123123456789";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Return_invalid_when_lenght_invalid_visa()
        {
            //arrange
            string number = "4408 0412 3456 78931";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_visa_4408_0412_3456_7893()
        {
            //arrange
            string number = "4408 0412 3456 7893";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_invalid_when_cred_card_is_visa_4417_1234_5678_9112()
        {
            //arrange
            string number = "4417 1234 5678 9112";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_visa_4111111111111111()
        {
            //arrange
            string number = "4111111111111111";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_invalid_when_cred_card_is_visa_4111111111111()
        {
            //arrange
            string number = "4111111111111";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_visa_4012888888881881()
        {
            //arrange
            string number = "4012888888881881";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_amex_378282246310005()
        {
            //arrange
            string number = "378282246310005";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_discover_6011111111111117()
        {
            //arrange
            string number = "6011111111111117";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_valid_when_cred_card_is_master_5105105105105100()
        {
            //arrange
            string number = "5105105105105100";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsTrue(valid);
        }

        [TestMethod]
        public void Return_invalid_when_cred_card_is_master_5105105105105106()
        {
            //arrange
            string number = "5105105105105106";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }

        [TestMethod]
        public void Return_invalid_when_cred_card_not_found_9111111111111111()
        {
            //arrange
            string number = "9111111111111111";

            var service = new ValidateCredCard();

            //act
            bool valid = service.IsValid(number);

            //assert
            Assert.IsFalse(valid);
        }
    }
}
