using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace BLayer
{
    public class BL
    {
        private DBL dbl = new DBL();
        public DataTable SearchElev(string Etternavn)
        {
            return dbl.SearchElev(Etternavn);
        }
        public DataTable Elev()
        { 
            return dbl.Elev(); 
        }
        public DataTable SearchFag(string Fag) 
        { 
            return dbl.SearchFag(Fag);
        }
    }
}
