using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    public class BadgeRepository
    {
       
            private Dictionary<int, List<string>> _badgeDictionary;

            public BadgeRepository()
            {
                _badgeDictionary = new Dictionary<int,List<string>>();
            }
            public void AddBadgeToList(Badge newBadge)
            {
                _badgeDictionary.Add(newBadge.BadgeID, newBadge.ListOfDoorNames);
            }
            public Dictionary<int,List<string>> GetBadgeList()
            {
                return _badgeDictionary;            }
            public void RemoveBadge(int newbadge)
            {
                _badgeDictionary.Remove(newbadge);
            }
        }
    }