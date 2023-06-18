using System;

namespace llab02
{
    

        public class Program
        {

            static void Main(string[] args)
            {

                Console.WriteLine("WELCOM AT ATM\n\n");
                UserInterface();


            }
            static public decimal Balance = 1000;
                public static void UserInterface()
                {
                    int number;
          
                    do
                    {
                        Console.WriteLine("If you want to inquire about the account balance please press (1)\n");
                        Console.WriteLine("If you want to withdraw an amount of money please press (2)\n");
                        Console.WriteLine("If you want to deposit an amount of money please press (3)\n");
                        Console.WriteLine("If you want to cancel the transaction please press (4)\n");
                        number =Convert.ToInt32( Console.ReadLine());
                        //To choose transaction
                        switch (number)
                        {
                            case 1:
                                ViewBalacne();
                                UserInterface();
                                break;
                            case 2:
                                     Console.WriteLine("Enter the amount you need to withdraw : ");
                                     decimal amount = Convert.ToDecimal(Console.ReadLine());
                                     Withdraw(amount);
                                     UserInterface();
                                break;
                            case 3:
                                     Console.WriteLine("Enter the amount you need to deposit : ");
                                     decimal amount2 = Convert.ToDecimal(Console.ReadLine());
                                     Deposit(amount2);
                                     UserInterface();
                                break;
                         
                                        
                            default:
                        if (number == 4)
                        {
                            Console.WriteLine("See You Another Time ");
                            Environment.Exit(0);
                        }else
                                     Console.WriteLine("The service is not found.");
                        break;
                        }

                    
                    }
                    while (number != 4);
                }
         
            public static decimal ViewBalacne()
            {
                Console.WriteLine($"Your balcane in your account is :{Balance}\n\n");
                return Balance;
            }
            public static decimal Withdraw(decimal amount)
            {
                
                
                decimal totalBalacne = Balance - amount;
                try
                {
                    if (Balance < amount)
                    {
                        throw new InvalidOperationException("You Dont Have Enough Balance To Do This Transaction\n\n");
                    }
                    if (amount <= 0)
                    {
                        throw new ArgumentException("Please Inter A Valid Value, Don't Kidding\n\n");
                    }

                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Wrong in withdraw: {ex.Message} \n\n");
                    return 0;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Wrong in withdraw: {ex.Message}\n\n");
                    return 0;
                }
                Console.WriteLine($"Dear Customer, {amount} has been withdrawn from your bank account through the ATM.\n Your current account balance is {totalBalacne}." +
                                  $" Thank you for using our banking services.\n\n");
                return totalBalacne;

            }
            public static decimal Deposit(decimal amount)
            {
              
                decimal totalBalacne = Balance + amount;
                try
                {
                    if (amount < 0)
                        throw new ArgumentException("Please Inter A Valid Value, Don't Kidding\n\n");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Deposit Fail!! {ex.Message}\n\n");
                    return 0;
                }
                Console.WriteLine($"Dear Customer,{amount} has been deposited into your bank account through the ATM.\n" +
                                  $" Your current account balance is {totalBalacne}. Thank you for your trust in us and for using our banking services.\n\n");
                return totalBalacne;
            }
        }
    }

