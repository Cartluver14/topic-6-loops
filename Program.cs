using Die_class;
using System.Runtime;

namespace topic_6_loops

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Bank");
                Console.WriteLine("3 - Dice Roller");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                var input = Console.ReadLine();
                choice = string.IsNullOrWhiteSpace(input) ? "q" : input.ToLower().Trim();
                Console.WriteLine();
                int num;

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");

                    Console.Write("Enter the minimum value: ");
                    var minInput = Console.ReadLine();
                    int min = !string.IsNullOrWhiteSpace(minInput) ? int.Parse(minInput) : 0;

                    Console.Write("Enter the maximum value: ");
                    var maxInput = Console.ReadLine();
                    int max = !string.IsNullOrWhiteSpace(maxInput) ? int.Parse(maxInput) : 0;

                    Console.WriteLine("Enter a number between min and max");
                    var numInput = Console.ReadLine();
                    num = !string.IsNullOrWhiteSpace(numInput) ? Convert.ToInt32(numInput) : 0;
                    if (num > min && num < max)
                    {
                        Console.WriteLine("Valid number, press ENTER to continue.");
                        Console.ReadLine();
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("nonvalid number press ENTER to continue.");
                        Console.ReadLine();
                    }
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    double balance = 150.0;
                    double fee = 0.75;
                    bool running = true;
                    string transactionChoice = "";
                    double amount;

                    Console.WriteLine("Welcome to my bank!");
                    Console.WriteLine("Each transaction costs $0.75.");

                    while (running)
                    {
                        Console.WriteLine("Choose a transaction:");
                        Console.WriteLine("1. Deposit");
                        Console.WriteLine("2. Withdraw");
                        Console.WriteLine("3. Pay Bill");
                        Console.WriteLine("4. Check Balance");
                        Console.WriteLine("5. Quit");
                        Console.Write("Enter choice: ");
                        transactionChoice = Console.ReadLine();



                        switch (transactionChoice)
                        {
                            case "1":
                                Console.Write("Enter deposit amount: ");
                                amount = Convert.ToDouble(Console.ReadLine());
                                if (amount > 0)
                                {
                                    balance += amount;
                                    balance -= fee;
                                    Console.WriteLine("Deposited $" + amount);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid deposit amount.");
                                }
                                Console.WriteLine($"Your balance is: ${balance}");
                                break;

                            case "2":
                                Console.Write("Enter withdrawal amount: ");
                                amount = Convert.ToDouble(Console.ReadLine());
                                if (amount > 0 && balance >= amount + fee)
                                {
                                    balance -= amount;
                                    balance -= fee;
                                    Console.WriteLine("Withdrew $" + amount);
                                    Console.WriteLine($"Your balance is: ${balance}");
                                }
                                else
                                {
                                    Console.WriteLine("Not enough funds or invalid amount.");
                                    balance -= fee;
                                    Console.WriteLine($"Your balance is: ${balance}");
                                }
                                break;

                            case "3":
                                Console.Write("Enter bill amount: ");
                                amount = Convert.ToDouble(Console.ReadLine());
                                if (amount > 0 && balance >= amount + fee)
                                {
                                    balance -= amount + fee;
                                    Console.WriteLine("Paid bill of $" + amount);
                                    Console.WriteLine($"Your balance is: ${balance}");
                                }
                                else
                                {
                                    Console.WriteLine("Payment failed.");
                                }
                                Console.WriteLine($"Your balance is: ${balance}");
                                break;

                            case "4":


                                balance -= fee;
                                Console.WriteLine("Your balance is: $" + balance);
                                Console.WriteLine($"Your balance is: ${balance}");
                                break;

                            case "5":
                                Console.WriteLine("Thank you for using the bank!");
                                running = false;
                                Console.WriteLine($"Your balance is: ${balance}");
                                break;

                            default:
                                Console.WriteLine("Invalid option, fee charged!");
                                balance -= fee;
                                break;
                        }

                        if (balance < 0)
                        {
                            Console.WriteLine("Warning: Your balance is gone ");
                        }
                    }

                    Console.WriteLine("Final Balance$" + balance);
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    // Do option 3
                    Die die1 = new Die();
                    Die die2 = new Die();
                    bool done = false;


                    Console.WriteLine("You chose option 3");
                    while (!done)
                    {
                        Console.WriteLine($"You rolled a {die1} and a {die2} for a total of {int.Parse(die1.ToString()) + int.Parse(die2.ToString())}");
                        die1.DrawRoll();
                        die2.DrawRoll();
                        if (die1.ToString() == die2.ToString())
                        {
                            Console.WriteLine("Doubles!  You get to roll again!");
                            done = true;


                        }
                        
                            Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                        die1.RollDie();
                        die2.RollDie();
                    }
                }







                else if (choice != "q")

                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
}
}
