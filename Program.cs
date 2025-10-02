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
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                var input = Console.ReadLine();
                choice = input == null ? "q" : input.ToLower().Trim();
                Console.WriteLine();
                int num;

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                   
                    Console.Write("Enter the minimum value");
                    int min = int.Parse(Console.ReadLine());

                   
                    Console.Write("Enter the maximum value");
                    int max = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter a number between min and max");
                    num = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...
                else if (choice != "q")
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
}
}
