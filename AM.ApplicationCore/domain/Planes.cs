using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Planes
    {


        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlanesID { get; set; }
        public PlaneType PlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
        public String Airlinelogo { get; set; }

    }
}
