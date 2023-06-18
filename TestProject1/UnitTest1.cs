using System;
using Xunit;
using llab02;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void WithdrawTest1()
        {

            decimal number = 150;
            decimal result = (Program.Withdraw(number));
            Assert.Equal(850,result);
           
              }
        [Fact]
        public void WithdrawTest2()
        {

            decimal number = 500000;
            decimal result = (Program.Withdraw(number));
             Assert.Equal(0,result);

        }
        [Fact]
        public void WithdrawTest3()
        {

            decimal number =-100;
            decimal result = (Program.Withdraw(number));
            Assert.Equal(0, result);

        }
        [Fact]
        public void DepositTest1()
        {

            decimal number = 100;
            decimal result = (Program.Deposit(number));
            Assert.Equal(1100, result);

        }
        //If negative
        [Fact]
        public void DepositTest2()
        {

            decimal number = -90;
            decimal result = (Program.Deposit(number));
            Assert.Equal(0 , result);
           

        }
    }
}
