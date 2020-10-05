using _02_Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using static _02_Claims.Claim;

namespace ClaimsConsole
{
    class ProgramUI
    {
        private readonly ClaimRepository _claimRepository = new ClaimRepository();

        public void Run()
        {
            //SeedClaims();
            RunMenu();
        }
        private void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select: \n" + "1) See all claims \n" +
                    "2) Take care of next claim \n" +
                    "3) Enter new claim \n" +
                    "4) Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Show All Claims
                        ShowAllClaims();
                        break;
                    case "2":
                        //Create New Item
                        ViewNextClaim();
                        break;
                    case "3":
                        //Remove Item
                        CreateNewClaim();
                        break;
                    case "4":
                        //Exit
                        continueToRun = false;
                        break;

                    default:
                        //default
                        Console.WriteLine("Please enter a valid number between 1 and 4. \n" + "press any key to continue......");
                        Console.ReadKey();
                        break;

                }
            }
        }
        /*private void SeedItems()
        {
            var itemOne = new MenuItem("Chicken Tenders", "1", "lightly breaded. Comes with choice of sauce and a side of fries.", 9.99, "Chicken breasts, potatoes, buttermilk, flour, egg");
            var itemTwo = new MenuItem("Stuffed Bell Peppers", "2", "Bell peppers stuffed with rice, ground beef, zucchini and tomatoes", 7.99, "Bell pepper, ground beef, onion, garlic, zucchini, white rice, pepper jack cheese, Roma tomatoes, red pepper flakes, black pepper, olive oil");
            var itemThree = new MenuItem("Filet Mignon", "3", "Cooked to your choice of temperature. Comes with a side of asparagus and mashed potatoes.", 21.99, "12 oz filet mignon, merlot wine, black pepper, sea salt, unslated butter, mashed potatoes, asparagus");

            _menuRepository.AddMenuItemToDirectory(itemOne);
            _menuRepository.AddMenuItemToDirectory(itemTwo);
            _menuRepository.AddMenuItemToDirectory(itemThree);

        }*/
        private void CreateNewClaim()
        {
            Claim claim = new Claim();
            //claim id
            Console.WriteLine("Enter the claim ID:");
            int intID = Convert.ToInt32(Console.ReadLine());
            claim.ClaimID = intID;
            //claim type
            Console.WriteLine("Enter the claim type: \n" + " 1) Car \n" + " 2) Home \n " + "3) Theft");
            string claimTypeRepsonse = Console.ReadLine();
            switch (claimTypeRepsonse)
            {
                case "1":
                    claim.TypeOfClaim = ClaimType.Car;
                    break;
                case "2":
                    claim.TypeOfClaim = ClaimType.Home;
                    break;
                case "3":
                    claim.TypeOfClaim = ClaimType.Theft;
                    break;
                default:
                    Console.WriteLine("Enter a valid number 1-3");
                    break;
            }
            // description
            Console.WriteLine($"Enter a brief description: ");
            claim.Description = Console.ReadLine();
            //claim amount
            Console.WriteLine($"Enter the amount of the claim: ");
            double amountResponse = Convert.ToDouble(Console.ReadLine());
            claim.ClaimAmount = amountResponse;
            //date of incident
            Console.Write("Enter the date of the incident date (e.g. '2009, 10, 28'): ");
            DateTime doiResponse = DateTime.Parse(Console.ReadLine());
            claim.DateOfIncident = doiResponse;
            //date of claim
            Console.Write("Enter the date of the claim(e.g. '2009, 10, 28'): ");
            DateTime docResponse = DateTime.Parse(Console.ReadLine());
            claim.DateOfClaim = docResponse;
            //checking if the claim is valid
            Console.WriteLine("Has the claim been made within 30 days of the incident?: Y/N ");
            string isValidResponse = Console.ReadLine();
            switch (isValidResponse)
            {
                case "Y":
                    claim.IsValid = true;
                    break;
                case "N":
                    claim.IsValid = false;
                    break;
                default:
                    Console.WriteLine("Enter a valid response: 'Y' or 'N'");
                    break;
            }
            _claimRepository.AddClaimToDirectory(claim);
        }

        private void ShowAllClaims()
        {
            Console.Clear();
            Queue<Claim> queueOfClaims = _claimRepository.GetClaims();
            foreach (Claim claim in queueOfClaims)
            {
                ShowAllProps(claim);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowAllProps(Claim claim)
        {
            Console.WriteLine($"{claim.ClaimID} {claim.TypeOfClaim } {claim.Description} ${claim.ClaimAmount} {claim.DateOfIncident} {claim.DateOfClaim} {claim.IsValid} ");
        }
        private void ViewNextClaim()
        {
            Queue<Claim> queueOfClaims = _claimRepository.GetClaims();
            Console.Clear();
            Console.WriteLine("Here are the details for the next claim to be handled: \n");
            

           
        }
    }
}
