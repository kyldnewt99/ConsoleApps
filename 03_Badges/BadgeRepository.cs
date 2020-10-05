using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    class BadgeRepository
    { 
        private readonly Dictionary<int, string> _idAndDoorName = new Dictionary<int, string>();

        //CREATE

        public bool AddBadgeToDirectory(int badge, string doorName)
        {
            int startingCount = _idAndDoorName.Count;
            _idAndDoorName.Add(badge, doorName );
            bool wasAdded = (_idAndDoorName.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //READ ALL

        public Dictionary<int, string> GetBagdes()
        {
            return _idAndDoorName;
        }

        //UPDATE

        public bool UpdateExistingBadge()
        {

        }
    }
}
