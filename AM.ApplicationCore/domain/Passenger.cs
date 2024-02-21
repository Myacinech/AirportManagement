using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Passenger

    {
        public int PassengerID { get; set; }
        public String PasseportNumber  { get; set; }
        public String  FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int TelNumber { get; set; }
        public String EmailAddress { get; set; }
        public int Id { get; set; }
        
        public IList<Flight> Flights { get; set; }
        public bool CheckProfile(String nom, String prenom)
        {
            return nom==this.FirstName && prenom==this.LastName;
        }

        public bool CheckProfile(String nom,String prenom, String email)
        {
            return nom==this.FirstName && prenom==this.LastName && email==this.EmailAddress;    
        }

        public bool login(String nom, String prenom, String email=null)
        {
          /*  if (email == null){
                return CheckProfile(nom, prenom);
            }else {
                return CheckProfile(nom, prenom, email);
            }*/

            return email==null ? CheckProfile(nom, prenom): CheckProfile(nom, prenom, email);
        }
        public virtual void PassengerType()
        {
            //cw+enter
            Console.WriteLine(" I am Passenger");
        }

    }
}
