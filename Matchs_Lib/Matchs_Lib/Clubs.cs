using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchs_Lib
{
    public class Clubs
    {
       // private List<Clubs> LClubs;
        private String _name;
        public Clubs(String name)
        {
            this._name = name;
        }
       
        public override string ToString()
        {
            return _name.ToString();
        }
    }
    
}
