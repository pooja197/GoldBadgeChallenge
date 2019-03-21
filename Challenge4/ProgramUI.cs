using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
  public  class ProgramUI
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();
        private Badge badge = new Badge();
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Main Menu:What would you like to do?\n" +
                    "1.Add a Badge.\n" +
                    "2.Edit a Badge.\n" +
                    "3.List all Badges.\n" +
                    "4.Exit.\n");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        AddBadge();
                        break;
                    case 2:
                        UpdateBadge();
                        break;
                    case 3:
                        GetBadgeList();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
        private void AddBadge()
        {
            Badge badge = new Badge();
            List<string> doors = new List<string>();
            Console.WriteLine("Hello, Please enter the BatchID.");
            badge.BadgeID = int.Parse(Console.ReadLine());

            Console.WriteLine($"{badge.BadgeID}! Now enter the door name you want access to?");
            string doorInput = Console.ReadLine();
            doors.Add(doorInput);

            bool running = true;
            while (running)
            {
                Console.WriteLine("Do you want to add more doors.\n" +
                    "Press 1\n" +
                    "Press 2");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:

                        Console.WriteLine($"{badge.BadgeID}Now enter the door name you want access to?");
                        string doorInputAsString = Console.ReadLine();
                        doors.Add(doorInput);
                        break;

                    case 2:
                        running = false;
                        break;

                }

            }
            badge.ListOfDoorNames = doors;
            _badgeRepo.AddBadgeToList(badge);



        }
        private void UpdateBadge()
        {
            Badge badge = new Badge();
            Dictionary<int, List<string>> badgeList = _badgeRepo.GetBadgeList();
            List<string> doors = new List<string>();

            foreach (KeyValuePair<int, List<string>> badgee in badgeList)
            {
                Console.WriteLine($"Following are The Badge keys:{badgee.Key}");
                foreach (string badge2 in badgee.Value)
                {
                    Console.WriteLine($"Here are the doors that it has access to: {badge2}");
                }
            }

            Console.WriteLine("Enter the batchID you want to update?");
            int idInput = int.Parse(Console.ReadLine());

            _badgeRepo.RemoveBadge(idInput);


            badge.BadgeID = idInput;

            Console.WriteLine($"{badge.BadgeID}Now enter the door name you want access to?");
            string doorInput = Console.ReadLine();
            doors.Add(doorInput);

            bool running = true;
            while (running)
            {
                Console.WriteLine("Do you want to add more doors.\n" +
                    "Press 1\n" +
                    "Press 2");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:

                        Console.WriteLine($"{badge.BadgeID}Now enter the door name you want access to?");
                        string doorInputAsString = Console.ReadLine();
                        doors.Add(doorInput);
                        break;

                    case 2:
                        running = false;
                        break;

                }

            }
            badge.ListOfDoorNames = doors;
            _badgeRepo.AddBadgeToList(badge);


        }
        private void GetBadgeList()
        {
            Console.WriteLine("Hello , here is your information:");

            Dictionary<int,List<string>> badgeList = _badgeRepo.GetBadgeList();

            foreach (KeyValuePair<int, List<string>> badge in badgeList)
            {
                Console.WriteLine($"Following are The Badge keys:{badge.Key}");
                foreach(string badge2 in badge.Value)
                {
                    Console.WriteLine($"Here are the doors that it has access to: {badge2}");
                }
            }
            Console.WriteLine("Press Enter to Continue: ");
            Console.ReadLine();
        }
    }

    }
