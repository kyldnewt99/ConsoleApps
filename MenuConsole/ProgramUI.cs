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
        private void RunMenu()
        {

        }
        private void SeedItems()
        {
            var itemOne = new MenuItem("Chicken Tenders", 1, "lightly breaded. Comes with choice of sauce and a side of fries.", 9.99, "Chicken breasts, potatoes, buttermilk, flour, egg");
            var itemTwo = new MenuItem("Stuffed Bell Peppers", 2, "Bell peppers stuffed with rice, ground beef, zucchini and tomatoes", 7.99, "Bell pepper, ground beef, onion, garlic, zucchini, white rice, pepper jack cheese, Roma tomatoes, red pepper flakes, black pepper, olive oil");
            var itemThree = new MenuItem("Filet Mignon",3,"Cooked to your choice of temperature. Comes with a side of asparagus and mashed potatoes.", 21.99, "12 oz filet mignon, merlot wine, black pepper, sea salt, unslated butter, mashed potatoes, asparagus");

            _menuRepository.AddMenuItemToDirectory(itemOne);
            _menuRepository.AddMenuItemToDirectory(itemTwo);
            _menuRepository.AddMenuItemToDirectory(itemThree);

        }
    }
}
