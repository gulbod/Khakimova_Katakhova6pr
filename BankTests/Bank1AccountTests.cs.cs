using Bank1AccountNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank1Tests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            Bank1Account account = new Bank1Account("Mr. Roman Abramovich", beginningBalance);

            
            account.Debit(debitAmount);

           
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
