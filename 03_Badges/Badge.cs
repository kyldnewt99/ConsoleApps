using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorName { get; set; }
        public Badge()
        {

        }
        public Badge(List<string> doorName, int badgeID)
        {
            DoorName = doorName;
            BadgeID = badgeID;
        }
    }
}
