using DevTeams_Repository;
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTeams_POCOs;

namespace ConseApp
{
    public class Program_UI
    {
        private readonly DeveloperRepository _devRepo;
        private readonly DeveloperTeamRepository _devTeamRepo;
        private int _count = 0;
       
        public Program_UI()
        {
            _devRepo = new DeveloperRepository();
            _devTeamRepo = new DeveloperTeamRepository(_devRepo);
            
        }

        public void Run()
        {
            Seed();
            RunApplication();
        }

        private void Seed()
        {
            Developer dev = new Developer();
            dev.FirstName = "Jason";
            dev.LastName = "Henson";
            dev.HasPluralsight = true;
            _devRepo.AddDeveloper(dev);
            
            Developer dev2 = new Developer();
            dev2.FirstName = "Bob";
            dev2.LastName = "Jones";
            dev2.HasPluralsight = false;
            _devRepo.AddDeveloper(dev2);
            
            Developer dev3 = new Developer();
            dev3.FirstName = "Jessica";
            dev3.LastName = "Jones";
            dev3.HasPluralsight = true;
            _devRepo.AddDeveloper(dev3);
            
            Developer dev4 = new Developer();
            dev4.FirstName = "David";
            dev4.LastName = "Williams";
            dev4.HasPluralsight = true;
            _devRepo.AddDeveloper(dev4);
            
            Developer dev5 = new Developer();
            dev5.FirstName = "Betty";
            dev5.LastName = "Wright";
            dev5.HasPluralsight = true;
            _devRepo.AddDeveloper(dev5);
            
            Developer dev6 = new Developer();
            dev6.FirstName = "Ron";
            dev6.LastName = "Douglas";
            dev6.HasPluralsight = true;
            _devRepo.AddDeveloper(dev6);
            
            Developer dev7 = new Developer();
            dev7.FirstName = "Tim";
            dev7.LastName = "George";
            dev7.HasPluralsight = true;
            _devRepo.AddDeveloper(dev7);
            
            Developer dev8 = new Developer();
            dev8.FirstName = "Vikki";
            dev8.LastName = "VanBuren";
            dev8.HasPluralsight = true;
            _devRepo.AddDeveloper(dev8);
            
            Developer dev9 = new Developer();
            dev9.FirstName = "Peter";
            dev9.LastName = "Parker";
            dev9.HasPluralsight = true;
            _devRepo.AddDeveloper(dev9);
            
            Developer dev10 = new Developer();
            dev10.FirstName = "Ororo";
            dev10.LastName = "Monrow";
            dev10.HasPluralsight = true;
            _devRepo.AddDeveloper(dev10);
            
            Developer dev11 = new Developer();
            dev11.FirstName = "Otto";
            dev11.LastName = "Octavius";
            dev11.HasPluralsight = true;
            _devRepo.AddDeveloper(dev11);
            
            Developer dev12 = new Developer();
            dev12.FirstName = "Louis";
            dev12.LastName = "Wu";
            dev12.HasPluralsight = true;
            _devRepo.AddDeveloper(dev12);
            
            Developer dev13 = new Developer();
            dev13.FirstName = "Teela";
            dev13.LastName = "Brown";
            dev13.HasPluralsight = true;
            _devRepo.AddDeveloper(dev13);
            
            Developer dev14 = new Developer();
            dev14.FirstName = "Bobby";
            dev14.LastName = "Blubland";
            dev14.HasPluralsight = true;
            _devRepo.AddDeveloper(dev14);
            
            Developer dev15 = new Developer();
            dev15.FirstName = "Redd";
            dev15.LastName = "Fox";
            dev15.HasPluralsight = true;
            _devRepo.AddDeveloper(dev15);
        }

        private void resetScreen()
        {
            Console.Clear();
            Console.WriteLine
                (
                "Welcome to dev teams\n" +
                "1.  Add A Developer\n" +
                "2.  View All Existing Developers\n" +
                "3.  View An Exiisting Developer\n" +
                "4.  Update An Exixisting Devleoper\n" +
                "5.  Delete An Existing Devleoper\n" +
                "6.  Add developer to a team\n" +
                "7.  Add multiple developers to a team\n" +
                "8.  Create new team empty team\n" +
                "9.  View all teams\n" +
                "10. Update Exsiting team" 
                 );
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                WriteLine("Welcome to dev teams\n" +
                "1.  Add A Developer\n" +
                "2.  View All Existing Developers\n" +
                "3.  View An Exiisting Developer\n" +
                "4.  Update An Exixisting Devleoper\n" +
                "5.  Delete An Existing Devleoper\n" +
                "6.  Add developer to a team\n" +
                "7.  Add multiple developers to a team\n" +
                "8.  Create new team empty team\n" +
                "9.  View all teams\n" +
                "10. Update Exsiting team"
                );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddADeveloper();
                        break;
                    case "2":
                        ViewAllExistingDevelopers();
                        break;
                    case "3":
                        ViewAnExiistingDeveloper();
                        break;
                    case "4":
                        UpdateAnExixistingDevleoper();
                        break;
                    case "5":
                        DeleteDeveloper();
                        break;
                    case "6":
                        AddDevToTeam();
                        break;
                    case "7":
                        AddMultipleDevsoTeam();
                        break;
                    case "8":
                        CreateNewTeam();
                        break;
                    case "9":
                        ViewAllTeams();
                        break;
                    case "10":
                        UpdateExistingTeam();
                        break;
                    default:
                        WriteLine("Invalid Seleciton");
                        WaitForKey();
                        break;
                }
                Clear();
            }
        }

        private void AddDevToTeam()
        {
            Console.Clear();
            DevTeam devTeam = new DevTeam();
            Developer developer = new Developer();
            Console.WriteLine("---------Assign Developer to Team---------\n" +
                "Please enter the team id the developer will be assinged to.");
            devTeam.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the devloper id for the person being assigned.");
            developer.ID = int.Parse(Console.ReadLine());
            _devTeamRepo.AddDevloperToTeam(devTeam.ID, developer.ID);
            Console.WriteLine("The developer has been assinged.\n" +
                "Press any key to continue.");
            Console.ReadKey();
        }

        private void AddMultipleDevsoTeam()
        {
            Console.Clear();
            DevTeam devTeam = new DevTeam();            
            List<Developer> developers = new List<Developer>();

            Console.WriteLine("---------Assign Multiple Developers to Team---------\n" +
                "Please enter the team id the developer will be assinged to.");
            devTeam.ID = int.Parse(Console.ReadLine());

            bool isTeamComplete = false;
            while(!isTeamComplete)
            {
                int lcv = 0;
                switch (lcv)
                {
                    case 0:
                        {
                            Developer dev = new Developer();
                            Developer dev2 = new Developer();
                            Console.WriteLine("Please enter the developer id to be assinged");
                            dev.ID = int.Parse(Console.ReadLine());
                            dev2 = _devRepo.LookupOneDveloper(dev.ID);
                            if(dev2 != null)
                            {
                                developers.Add(dev2);
                                lcv+= 1;
                            }                            
                        }
                        break;
                        case 1:
                        {
                            Developer dev = new Developer();
                            Developer dev2 = new Developer();
                            Console.WriteLine("Press (1) to add another developer or (2) if your are done.");
                            string response = Console.ReadLine();
                            if(response == "1")
                            {
                                Console.WriteLine("Please enter the developer id to be assinged");
                                dev.ID = int.Parse(Console.ReadLine());
                                dev2 = _devRepo.LookupOneDveloper(dev.ID);
                                if (dev2 != null)
                                {
                                    developers.Add(dev2);
              
                                }
                            }
                            else
                            {
                                isTeamComplete = true;
                            }
                         

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Invalid input fatal error please restar order.");
                        }
                        break;
                }
                if (isTeamComplete)
                {

                }
               

            }
            _devTeamRepo.AddMultipleDevelopers(devTeam.ID, developers);

            Console.WriteLine("Developrs have been assinged.");
        }

        private bool CreateNewTeam()
        {
            Console.Clear();
            DevTeam devTeam = new DevTeam();
            Console.WriteLine("----------Create New Team---------\n" +
                "Please senter the team name ");
            devTeam.TeamName = Console.ReadLine();
            _devTeamRepo.AddContentToInventory(devTeam);
            return true;
        }

        private void ViewAllTeams()
        {
            Console.WriteLine("----------View All Teams----------\n");
            List<DevTeam>  list = new List<DevTeam>();
            list = _devTeamRepo.GetAllTeams();
            foreach (DevTeam devTeam in list)
            {
                Console.WriteLine($"\n" +
                    $"Team Id: {devTeam.ID}\n" +
                    $"Team Name: {devTeam.TeamName}\n" +
                    $"==================================");
            }

        }

        private void UpdateExistingTeam()
        {
            Console.Clear();
            DevTeam devTeam = new DevTeam();
            Console.WriteLine("---------Update DevTeam----------\n" +
                "*** To add or removed developers form the teeam user function (5) ***\n" +
                "\n" +
                "Enter the team id of the team you wish to update. ");
            devTeam.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the updated team name");
            devTeam.TeamName = Console.ReadLine();
            _devTeamRepo.UpdateDevTeam(devTeam.ID, devTeam);
            Console.WriteLine("The devteam has been updated.\n" +
                "Press any key to continue.");
            Console.ReadKey();
            resetScreen();
        }

        private void WaitForKey()
        {
           
            
        }

        private void DeleteAnExistingDevleoper()
        {
            List<Developer> devs = new List<Developer>();
            devs = _devRepo.LookUpAllDevelopers();
            Developer developer = new Developer();
            Console.WriteLine("-----------Remove Existing Developer-----------\n" +
                "Enter the id number of the developer you want to remove");
            int id = int.Parse(Console.ReadLine());
            if(id > -1 && id <= devs.Count)
            {
                Developer devToDelete = devs[id];
                _devRepo.LookupOneDveloper(id);
                _devRepo.DeleteExistingDeveloper(devToDelete);
                Console.WriteLine($"Developer id: {id} has been deleted.\n" +
                    $"Press any key to continue.");
                Console.ReadKey();
                resetScreen();
            }
            else
            {
                Console.WriteLine("Please verify the developer id and try again.");
                Console.ReadKey();
                resetScreen();
            }
            
            Console.WriteLine("The developer has been updated\n" +
                "Press any key to continue.");
            Console.ReadKey();
            resetScreen();

        }

        private void UpdateAnExixistingDevleoper()
        {
            int value;
            Developer developer = new Developer();
            List<Developer> devs = _devRepo.LookUpAllDevelopers();
            int maxRange = devs.Count;
            Console.WriteLine("-----------Update Existing Developer-----------\n" +
                "Enter the id number of the developer you want to update");
            string idResponse = ReadLine();
            /*int id = int.Parse(idResponse);*/
            bool hasValidatedUser = false;
            while (!hasValidatedUser)
            {
                if (!int.TryParse(idResponse, out value))
                {
                    Console.Clear();
                    Console.WriteLine("Please enter the numeric devloper id." +
                        "  Try using view all developers fucntion (option 2 main menu) to check the id");
                    Console.WriteLine("Invalid operation retuning to main menu.\n" +
                        "Press any key to continue.");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("Firstname: ");
                developer.FirstName = Console.ReadLine();
                Console.WriteLine("Lastname: ");
                developer.LastName = Console.ReadLine();
                Console.WriteLine("Enter (1) if the developer has Pluralsight (2) if they do not.");
                String pluralSightResponse = Console.ReadLine();
                switch (pluralSightResponse)
                {
                    case "1": { developer.HasPluralsight = true; } break;
                    case "2": { developer.HasPluralsight = false; } break;
                    default: { Console.WriteLine("Please enter either '1' or '2'."); } break;
                }
                _devRepo.UpdateExistingDeveloper(int.Parse(idResponse), developer);
                Console.WriteLine("The developer has been updated\n" +
                    "Press any key to continue.");
                hasValidatedUser = true;
            }
            
            Console.ReadKey();
            resetScreen();
        }

        private void ViewAnExiistingDeveloper()
        {
            Developer developer = new Developer();
            Console.WriteLine("Enter the id number for the devleoper you want to view.");
            int id = int.Parse(Console.ReadLine());
            developer = _devRepo.LookupOneDveloper(id);
            Console.WriteLine($"View Developer By ID\n" +
                $"Developer ID {developer.ID}\n" +
                $"Firstname: {developer.FirstName}\n" +
                $"Lastname: {developer.LastName}\n" +
                $"Pluralsight Access: {developer.HasPluralsight}\n" +
                $"------------------------------------\n" +
                $"" +
                $"Press any key to continue.");
            Console.ReadKey();
            resetScreen();
        }
           

        private void ViewAllExistingDevelopers()
        {
            List<Developer> developers = new List<Developer>();
            Console.WriteLine("View all devlopers");
            developers = _devRepo.LookUpAllDevelopers();
            foreach (var d in developers)
            {
                Console.WriteLine("=================================\n" +
                    "");
                Console.WriteLine($"Developer ID: {d.ID}");
                Console.WriteLine($"Developer Firstname: {d.FirstName}");
                Console.WriteLine($"Developer Lastname: {d.LastName}");
                Console.WriteLine($"Pluralsight Access: {d.HasPluralsight}" );
            }
            Console.WriteLine("-----------------------------------\n" +
                "Press any key to contine");
            Console.ReadKey();
            resetScreen();
        }

        private void AddADeveloper()
        {
            Developer developer = new Developer();
            Console.WriteLine("Add a new developer:\n" +
                "=======================================\n" +
                "Firstname: ");
            developer.FirstName = Console.ReadLine();
            Console.WriteLine("Lastname: ");
            developer.LastName = Console.ReadLine();
            Console.WriteLine("Enter 'y' if new developer has Pluralsight or 'n' if they don't");
            String pluralightResponse = Console.ReadLine().ToLower();
            if (pluralightResponse == "y")
            {
                developer.HasPluralsight = true;
            }
            else if (pluralightResponse == "n")
            {
                developer.HasPluralsight = false;
            }
            else
            {
                Console.WriteLine("Please enter either 'y' or 'n'.");
            }
            _devRepo.AddDeveloper(developer);
            Console.WriteLine("Your new developer has been added\n" +
                "Press any key to contine");
            Console.ReadKey();
            resetScreen();           
        }

        private bool DeleteDeveloper()
        {
            Console.Clear();
            Developer developer = new Developer();
            string id;
            Console.WriteLine("----------Remove developer----------\n" +
                "Enter the developer id for developer to be removed. ");
            id = Console.ReadLine();
            developer = _devRepo.LookupOneDveloper(int.Parse(id));
            _devRepo.DeleteExistingDeveloper(developer);
            Console.WriteLine("The developer has been removed.\n" +
                "Please press any key to continue.");
            resetScreen();
            return true;  
        }
    }
}
