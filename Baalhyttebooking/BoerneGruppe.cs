using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Boernegruppe
    {
        public string _id { get; set; }
        public string _navn { get; set; }   
        public string _aldersGruppe { get; set; }   
        public int _antalDeltagere { get; set; } 

        public Boernegruppe(string id, string navn, string aldersGruppe, int antalDeltagere) 
        {
            _id = id;
            _navn = navn;   
            _aldersGruppe= aldersGruppe;
            _antalDeltagere = antalDeltagere;
        }

        public override string ToString()
        {
            return $"Id: {_id}\nNavn: {_navn}\nAldersgruppe: {_aldersGruppe}\nAntal deltagere: {_antalDeltagere}\n";
        }
    }
}
