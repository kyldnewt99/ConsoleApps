using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_KomodoCafe
{
   public class MenuRepository
    {
        protected readonly List<MenuItem> _menuDirectory = new List<MenuItem>();

        //CREATE
        public bool AddMenuItemToDirectory(MenuItem item)
        {
            int startingCount = _menuDirectory.Count;
            _menuDirectory.Add(item);
            bool wasAdded = (_menuDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //READALL
        public List<MenuItem> GetMenuItems()
        {
            return _menuDirectory;
        }
        
        //DELTE
        public bool DeleteExistingItem(MenuItem existingItem)
        {
            bool deleteResult = _menuDirectory.Remove(existingItem);
            return deleteResult;

        }
    }
}
