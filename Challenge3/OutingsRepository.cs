using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3
{
    public class OutingsRepository
    {
        private List<Outings> _outingsList;

        public OutingsRepository()
        {
            _outingsList = new List<Outings>();
        }
        public void AddProduct(Outings newoutings)
        {
            _outingsList.Add(newoutings);
        }

       

     
      
        
            public List<Outings> VeiwEvents()
            {
                return _outingsList;
            }

        }
    }
