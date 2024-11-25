using System.Numerics;

namespace Lab1
{
    internal class Program
    {

        static void Main()
        {
            int newYorkDepartureTimeHour = 10;
            int newYorkDepartureTimeMin = 10;
            int newYorkToStockholmTimeZoneDiffernece = 6;
            int stockholmDepartureTimeHour = 14;
            int stockholmDepartureTimeMin = 3;
            int stockholmToNewYorkTimeZoneDiffernece = -6;
            bool menu = true;
            while (menu)
            {
                Console.Write("\n\t\tFlight Table \n\n\t[1] Stockholm -> New York\n\t[2] New York -> Stockholm\n\t[3] End Program");
                Console.Write("\n\tCHOICE: ");
                Int32.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\tStockholm to New York\n");
                        FlightCalculation(stockholmDepartureTimeHour, stockholmDepartureTimeMin, stockholmToNewYorkTimeZoneDiffernece); 
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\tNew York to Stockholm\n");
                        FlightCalculation(newYorkDepartureTimeHour, newYorkDepartureTimeMin, newYorkToStockholmTimeZoneDiffernece);
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
        static void FlightCalculation(int departureHour, int departureMin, int timeZone)
        {
            string departureHourStr = departureHour.ToString("00");
            string departureMinStr = departureMin.ToString("00");
            int travelTimeHour = 7;
            int travelTimeMin = 25;

            int arrivalTimeHour = (((departureHour * 60) + (travelTimeHour * 60) + (timeZone * 60)) / 60);
            if (arrivalTimeHour >= 24)
            {
                arrivalTimeHour -= 24;
            }
            int arrivalTimeMin = departureMin + travelTimeMin;
            string arrivalTimeHourStr = arrivalTimeHour.ToString("00");
            string arrivalTimeMinStr = arrivalTimeMin.ToString("00");

            Console.WriteLine($"\n\tThe plane departs at: {departureHourStr}:{departureMinStr}" +
            $"\n\tThe plane arrives at: {arrivalTimeHourStr}:{arrivalTimeMinStr}");

        }
    }
}
