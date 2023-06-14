using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservation
    {
        public int _id { get; set; }
        public DateTime _tidspunkt { get; set; }
        public Boernegruppe _boernegruppe { get; set; }

        public Reservation(int id, DateTime tidspunkt, Boernegruppe boernegruppe) 
        { 
            _id = id;
            _tidspunkt = tidspunkt;
            _boernegruppe = boernegruppe;
        }    

        public override string ToString() 
        {
            string overskrift = $"\nReservation: {_id}";
            string streger = "\n------------------------------\n";
            string result = $"Id: {_id}\nTidspunkt: {_tidspunkt}\n\nBørnegruppe:\n";
            result += _boernegruppe.ToString();

            return overskrift + streger + result + streger;
        }

    }
}
