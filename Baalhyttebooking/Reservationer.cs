using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
        public int _id { get { return _id;} private set { _id = value; } }    
        public Dictionary<int, Reservation> _reservationer;
        
        public Reservationer() 
        {
            _reservationer = new Dictionary<int, Reservation>();
        } 

        public void RegistrerReservation(Reservation reservation)
        {
            if(!_reservationer.Keys.Contains(reservation._id)) 
            {
                _reservationer.Add(reservation._id, reservation);   
            }  
        }

        public void PrintReservationer()
        {
            foreach(Reservation reservation in _reservationer.Values) 
            { 
                Console.WriteLine(reservation.ToString());  
            }
        }

        public void FjerneReservation(Reservation reservation)
        {
            if (_reservationer.Keys.Contains(reservation._id))
            {
                _reservationer.Remove(reservation._id);
            }
        }

        public int AntalReservationer(Boernegruppe boernegruppe) 
        {
            int antalReservationer = 0;
            foreach(Reservation reservation in _reservationer.Values)
            {
                if (reservation._boernegruppe == boernegruppe)
                {
                    antalReservationer ++;  
                }
            }
            return antalReservationer;
        }

        public bool ReservationLedig(Reservation reservation)
        {
            foreach(Reservation res in _reservationer.Values) 
            {
                if(res._tidspunkt == reservation._tidspunkt)
                return false;
            }
            return true;
        }

        public bool ReservationOK(Reservation reservation)
        {
            int antalReservationer = AntalReservationer(reservation._boernegruppe);
            bool reservationLedig = ReservationLedig(reservation);
            if(reservation != null && antalReservationer <= 2 && reservationLedig == true)
            {
                return true;
            }
            return false;
        }

    }
}
