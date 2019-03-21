using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> ListOfDoorNames { get; set; }

        public Badge() { }
        public Badge(int badgeID, List<string> listofdoornames)
        {
            BadgeID = badgeID;
            ListOfDoorNames = listofdoornames;
        }
    }
}
