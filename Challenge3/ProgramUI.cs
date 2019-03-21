using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class ProgramUI
    {
        private static OutingsRepository _outingsRepo = new OutingsRepository();
        private Outings outings = new Outings();
        private List<Outings> _outingList = _outingsRepo.VeiwEvents();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Main Menu:\n" +
                    "1.Add An Outing\n" +
                    "2. Cost per outings\n" +
                    "3.Cost of all Outings\n" +
                    "4. Veiw Events\n" +
                    "5. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        CalculateTotalCostPerEvent();
                        break;
                    case 3:
                        CalculateTotalCostOfAll();
                        break;
                    case 4:
                        VeiwEvents();
                        break;
                    case 5:
                        running = false;
                        break;

                }

            }
        }
        private void AddProduct()
        {
            Outings outings = new Outings();
            Console.WriteLine("Hi,enter the type of outing\n" +
                "1.Golf\n" +
                "2.Bowling\n" +
                "3.Amusement Park\n" +
                "4. Concert");
            string outingsTypeAsString = Console.ReadLine().ToLower();

            Console.WriteLine("How many people attended the event?");
            outings.NumberOfPeopleAttended = int.Parse(Console.ReadLine());

            Console.WriteLine("write the date?");
            outings.Date = Console.ReadLine();

            Console.WriteLine("Enter the total cost per person");
            outings.TotalCostPerEvent = decimal.Parse
                (Console.ReadLine());

           
            _outingsRepo.AddProduct(outings);

        }
        public void CalculateTotalCostPerEvent()
        {
            decimal golf = 199m;
            decimal bowling = 99m;
            decimal amusementPark = 110m;
            decimal concert = 300m;
           
            Console.WriteLine("Enter an item number for the total price. \n" +
                "1. Golf \n" +
                "2. Bowling \n" +
                "3. Amusementpark \n" +
                "4. COncert");
            string productTypeAsString = Console.ReadLine().ToLower();
            switch (productTypeAsString)
            {
                
                case "1":
                    
                    foreach (var outings in _outingList)
                    {
                        if (outings.TypeOfOuting == OutingType.Golf)
                        {
                            golf +=  outings.TotalCostPerEvent * outings.NumberOfPeopleAttended;
                            Console.WriteLine($"Price per event for golf {golf}");
                            Console.ReadLine();

                        }
                    }
                    break;
                
                case "2":
                    foreach (var outings in _outingList)
                    {
                        if (outings.TypeOfOuting == OutingType.Bowling)
                        {
                            bowling += outings.TotalCostPerEvent * outings.NumberOfPeopleAttended;
                            Console.WriteLine($"Price per event for bowling {bowling}");
                            Console.ReadLine();

                        }
                    }
                    break;
               
                case "3":
                    foreach (var outings in _outingList)
                    {
                        if (outings.TypeOfOuting == OutingType.AmusementPark)
                        {
                           amusementPark += outings.TotalCostPerEvent * outings.NumberOfPeopleAttended;
                            Console.WriteLine($"Price per event for Amusement park {amusementPark}");
                            Console.ReadLine();
                        }
                    }
                    break;
               
                case "4":
                    foreach (var outings in _outingList)
                    {
                        if (outings.TypeOfOuting == OutingType.Concert)
                        {
                            concert += outings.TotalCostPerEvent * outings.NumberOfPeopleAttended;
                            Console.WriteLine($"Price per event for concert {concert}");
                            Console.ReadLine();
                        }
                    }
                    break;


            }
        }
        private void CalculateTotalCostOfAll()
        {
            var totalcostofevent = 0m;
            foreach (var outings in _outingList)
            {
                totalcostofevent += outings.TotalCostPerEvent*outings.NumberOfPeopleAttended ;
                Console.WriteLine($"Total cost of all outings{totalcostofevent}");
                Console.ReadLine();
            }
           
        }

        private void VeiwEvents()
        {
            Console.WriteLine("Hello , here is your information:");

            List<Outings> outings = _outingsRepo.VeiwEvents();
            foreach (Outings outing in outings)
            {
                Console.WriteLine($"Type of Outing: {outing.TypeOfOuting} \n" +
                    $"Number of People Attended: {outing.NumberOfPeopleAttended} \n" +
                    $"Date: {outing.Date} \n" +
                    $"Total cost per Event: {outing.TotalCostPerEvent}\n");
                   
            }
            Console.WriteLine("Press Enter to Continue: ");
            Console.ReadLine();
        }

    }
}
