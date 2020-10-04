using _01_KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuConsole
{
    class ProgramUI
    {
        private readonly MenuRepository _menuRepository = new MenuRepository();
        
        public void Run()
        {
            SeedItems();
            RunMenu();
        }
        private void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select: \n" + "1) Show all menu items \n" +
                    "2) Add a menu item \n" +
                    "3) Remove a menu item \n" +
                    "4) Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Show All Items
                        ShowAllItems();
                        break;
                    case "2":
                        //Create New Item
                        CreateNewMenuItem();
                        break;
                    case "3":
                        //Remove Item
                        RemoveItemFromList();
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
        private void SeedItems()
        {
            var itemOne = new MenuItem("Chicken Tenders", "1", "lightly breaded. Comes with choice of sauce and a side of fries.", 9.99, "Chicken breasts, potatoes, buttermilk, flour, egg");
            var itemTwo = new MenuItem("Stuffed Bell Peppers", "2", "Bell peppers stuffed with rice, ground beef, zucchini and tomatoes", 7.99, "Bell pepper, ground beef, onion, garlic, zucchini, white rice, pepper jack cheese, Roma tomatoes, red pepper flakes, black pepper, olive oil");
            var itemThree = new MenuItem("Filet Mignon","3","Cooked to your choice of temperature. Comes with a side of asparagus and mashed potatoes.", 21.99, "12 oz filet mignon, merlot wine, black pepper, sea salt, unslated butter, mashed potatoes, asparagus");

            _menuRepository.AddMenuItemToDirectory(itemOne);
            _menuRepository.AddMenuItemToDirectory(itemTwo);
            _menuRepository.AddMenuItemToDirectory(itemThree);

        }
        private void CreateNewMenuItem()
        {
            MenuItem item = new MenuItem();
            //meal name
            Console.WriteLine("Enter the meal name: ");
            item.MealName = Console.ReadLine();
            //description
            Console.WriteLine($"Enter the description for {item.MealName}: " );
            item.Description = Console.ReadLine();
            //ingredients
            Console.WriteLine($"Enter the ingredients for {item.MealName}: ");
            item.Ingredients = Console.ReadLine();
            //meal number
            Console.WriteLine($"Enter the meal number for {item.MealName}: ");
            item.MealNumber = Console.ReadLine();
            //meal price
            Console.WriteLine($"Enter the price for {item.MealName}: ");
            
            string itemPrice = Console.ReadLine();
            //convert user input into a double
            double priceID = double.Parse(itemPrice);
            item.Price = priceID;
            _menuRepository.AddMenuItemToDirectory(item);
        }
        private void ShowAllItems()
        {
            Console.Clear();
            List<MenuItem> listofItems = _menuRepository.GetMenuItems();
            foreach(MenuItem item in listofItems)
            {
                ShowSimple(item);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void ShowSimple(MenuItem item)
        {
            Console.WriteLine($"{item.MealName} {item.Price} \n" + "----------------------------");
        }
        private void RemoveItemFromList()
        {
            Console.WriteLine("Select the meal you'd like to remove:");

            List<MenuItem> itemList = _menuRepository.GetMenuItems();

            int i = 0;

            foreach(var item in itemList)
            {
                i++; //so it starts at "1" instead of "0" on console.writeline
                Console.WriteLine($"{i}) {item.MealName}");
            }
            //takes what the user enters and converts it to an int
            int targetContentID = Convert.ToInt32(Console.ReadLine());
            //subtracts to take into account the i++
            int correctIndex = targetContentID - 1;
            if (correctIndex >= 0 && correctIndex < itemList.Count)
            {
                MenuItem desiredItem = itemList[correctIndex];

                if (_menuRepository.DeleteExistingItem(desiredItem))
                {
                    Console.WriteLine($"{desiredItem.MealName} removed.");
                }
                else
                {
                    Console.WriteLine("Unable to remove.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
