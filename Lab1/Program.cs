using System.Numerics;

namespace Lab1
{
    internal class Program
    {

        static void Main()
        {
            // Vi deklararera och instansierar flyg och tidzons information 
            int newYorkDepartureTimeHour = 10;
            int newYorkDepartureTimeMin = 10;
            int stockholmDepartureTimeHour = 14;
            int stockholmDepartureTimeMin = 3;
            int timeZone = 6;
            string lineSeperator = "\t*****************************************";
            /*
            Vi deklarerar och instansier en bool för att 
            använda den som condition i våran while-loop, 
            */
            bool menu = true;
            while (menu)
            {
                /*
                 vi använder while-loopen för att skapa en menu,
                vi använder en while-loop för att vi vill at programmet 
                ska fortsätta tills användaren väljer att stänga av den,
                 */
                Console.WriteLine($"{lineSeperator}\n\t\t\tFlight Table \n\n\t\t[1] Stockholm -> New York\n\t\t[2] New York -> Stockholm\n\t\t[3] End Program");
                Console.Write("\n\t\tCHOICE: ");
                /*
                 vi tar in en string-input från användaren och försöker 
                konvertera den till en int32
                som vi sedan använder som condition i våran switch-sats.
                 */
                Int32.TryParse(Console.ReadLine(), out int userInput);
                switch (userInput)
                {
                    /*
                     En av 4 olika val händer beroende på användarens input.
                    case 1 och case 2 skriver ut en flygdestinationer och tiden 
                    flygen anländer och avgår med hjälp av FlightCalculation metoden
                    case 3 sätter våran loop condition till false och avslutar programmet
                    default skriver ut instruktioner om användaren skriver in ett felaktigt val
                     */
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"{lineSeperator}\n\t\tStockholm to New York\n");
                        FlightCalculation(stockholmDepartureTimeHour, stockholmDepartureTimeMin, -timeZone, lineSeperator);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"{lineSeperator}\n\t\tNew York to Stockholm\n");
                        FlightCalculation(newYorkDepartureTimeHour, newYorkDepartureTimeMin, timeZone, lineSeperator);
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
        /*
        vi konverterar vår avgångstid till string för att få tvåtals precision
        vi deklarerar och instansierar färdtiden
        vi gör uträkning från tidigare givna parametrar som ger oss ankomsttiden
        som vi sen konverterar till en tvåtals string
        programmet skriver ut när planet avgår och anländer
         */
        static void FlightCalculation(int departureHour, int departureMin, int timeZone, string line)
        {
            string departureHourStr = departureHour.ToString("00");
            string departureMinStr = departureMin.ToString("00");
            int travelTimeHour = 7;
            int travelTimeMin = 25;
            // vi konverterar allt till minuter så allt kan
            // adderas och sedan kan konverteras tillbaks till timmar
            int arrivalTimeHour = (((departureHour * 60) + (travelTimeHour * 60) + (timeZone * 60)) / 60);
            int arrivalTimeMin = departureMin + travelTimeMin;
            string arrivalTimeHourStr = arrivalTimeHour.ToString("00");
            string arrivalTimeMinStr = arrivalTimeMin.ToString("00");

            Console.WriteLine($"{line}\n\t\tThe plane departs at: {departureHourStr}:{departureMinStr}" +
            $"\n\t\tThe plane arrives at: {arrivalTimeHourStr}:{arrivalTimeMinStr}\n");

        }
    }
}