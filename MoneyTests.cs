using NUnit.Framework;

namespace tdd_demo
{
    [TestFixture]
    public class MoneyTests
    {
        [Test]
        public void Money_Times_Multiplies_The_Amout()
        {
            //arrange
            var firstAmout = 10;
            var multiply = 2;
            var expected = firstAmout * multiply;

            var money = new Money();
            money.Amount = firstAmout;

            //act
            money.Times(multiply);

            //assert
            Assert.AreEqual(money.Amount, expected);
        }
    }

    public class Money
    {
        public decimal Amount { get; set; }

        public void Times(int multiply)
        {
            Amount = Amount * multiply;
        }
    }
}
