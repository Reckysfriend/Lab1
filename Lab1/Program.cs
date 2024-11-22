namespace Lab1
{
    internal class Program
    {

        static void Main()
        {
            int newYorkDepartureTimeHour = 10;
            int newYorkDepartureTimeMin = 10;
            int stockholmDepartureTimeHour = 14;
            int stockholmDepartureTimeMin = 3;
            int travelTimeHour = 7;
            int travelTimeMin = 25;
            int timeZoneDifference = 6;
            string stockholmDepartureTimeMinStr = stockholmDepartureTimeMin.ToString("00");
            int newYorkArrivalTimeHour = ((newYorkDepartureTimeHour * 60) + (travelTimeHour * 60) - (timeZoneDifference * 60)) / 60;
            int newYorkArrivalTimeMin = newYorkDepartureTimeMin + travelTimeMin;
            int stockholmArrivalTimeHour = ((stockholmDepartureTimeHour * 60) + (travelTimeHour * 60) + (timeZoneDifference * 60)) / 60;

            if (stockholmArrivalTimeHour >= 24)
            {
                stockholmArrivalTimeHour = stockholmArrivalTimeHour - 24;
            }
            string stockholmArrivalTimeHourStr = stockholmArrivalTimeHour.ToString("00");
            int stockholmArrivalTimeMin = stockholmDepartureTimeMin + travelTimeMin;
            bool menu = true;
            while (menu)
            {
                Console.Write("\n\t\tFlight Table \n\n\t[1] Stockholm - New York\n\t[2] New York -> Stockholm\n\t[3] End Program");
                Console.Write("\nCHOICE: ");
                Int32.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"\tStockholm to New York\n\nThe plane departs at: {newYorkDepartureTimeHour}:{newYorkDepartureTimeMin}" +
                            $"\nThe plane arrives at: {newYorkArrivalTimeHour}:{newYorkArrivalTimeMin}");

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"\tStockholm to New York\n\nThe Plane departs at: {stockholmDepartureTimeHour}:{stockholmDepartureTimeMinStr}" +
                        $"\nThe plane arrives at: " + stockholmArrivalTimeHourStr + $":{stockholmArrivalTimeMin}");
                        break;
                    case 3:
                        menu = false;
                        Environment.Exit(0);
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
