namespace Lab1
{
    internal class Program
    {

        static void Main()
        {
            int newYorkDepartureTimeHour = 10;
            int newYorkDepartureTimeMin = 10;
            int stockholmDepartureTimeHour = 14;
            int stockholmDepartureTimeMin = 03;
            string stockholmDepartureTimeMinStr = stockholmDepartureTimeMin.ToString("00");

            Console.WriteLine(newYorkDepartureTimeHour);
            Console.WriteLine(newYorkDepartureTimeMin);
            Console.WriteLine(stockholmDepartureTimeHour);
            Console.WriteLine(stockholmDepartureTimeMinStr);
            
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
                        Console.WriteLine($"\tStockholm to New York\n\nThe Plane departs at: {newYorkDepartureTimeHour}:{newYorkDepartureTimeMin}");
                        Console.WriteLine($"\tStockholm To New York\n\nThe Plane arrives at: {newYorkDepartureTimeHour}{+}{7}:{newYorkDepartureTimeMin}"
                        Console.ReadLine();
                        menu = false;
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"\tStockholm to New York\n\nThe Plane departs at: {stockholmDepartureTimeHour}:{stockholmDepartureTimeMinStr}");
                        Console.ReadLine();
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
