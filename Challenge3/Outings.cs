using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public enum OutingType
    {
        Golf,Bowling,AmusementPark,Concert
    }
    public class Outings
    {
        public int NumberOfPeopleAttended { get; set; }
        public string Date { get; set; }
        public decimal TotalCostPerEvent { get; set; }
       
        public OutingType TypeOfOuting { get; set; }
        public Outings() { }
        public Outings(int
            numberofpeopleattended,string date,decimal totalcostperevent
            
     
            
   )
        {
            NumberOfPeopleAttended =numberofpeopleattended;
            Date = date;
            TotalCostPerEvent = totalcostperevent;
            
        }
    }
}
