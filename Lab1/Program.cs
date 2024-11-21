namespace Lab1
{
    internal class Program
    {
        static void Main()
        {
            //string newyorktostockholm = Console.ReadLie();
            //string stockholmtonewyork = Console.ReadLine();
            bool menu = true;
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("\n\t\tFlight Table \n\n\t[1] Stockholm - New York\n\t[2] New York -> Stockholm");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("S -> NY");
                        menu = false;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("NY -> S");
                        menu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid choice");
                        break;
                }
            }
        }
    }
}
