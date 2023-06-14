namespace Baalhyttebooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opgave1 = "\n|Opgave 1|";
            string opgave2 = "\n|Opgave 2|";
            string opgave6 = "\n|Opgave 6|";
            string opgave7 = "\n|Opgave 7|";
            string opgaveAdskillelse = "\n--------------------------------------------------------\n\n";

            //Opgave 1: tester klassen "Boernegruppe"
            Boernegruppe boernegruppe1 = new Boernegruppe("1", "Rovfuglene", "pusling", 5);
            Boernegruppe boernegruppe2 = new Boernegruppe("2", "Fiskene", "tumling", 8);

            Console.WriteLine(opgave1 + opgaveAdskillelse);
            Console.WriteLine(boernegruppe1.ToString());
            Console.WriteLine(boernegruppe2.ToString());

            //Opgave 2: tester klassen "Reservationer"
            Reservation reservation1 = new Reservation(1, new DateTime(2023,06,5,12,00,00), boernegruppe1);
            Reservation reservation2 = new Reservation(2, new DateTime(2023,06,5,14,00,00), boernegruppe2);
            Reservation reservation3 = new Reservation(3, new DateTime(2023,06,6,12,00,00), boernegruppe2);
            Reservation reservation4 = new Reservation(4, new DateTime(2023,06,06,14,00,00), boernegruppe1);

            Console.WriteLine(opgave2 + opgaveAdskillelse + reservation1.ToString());

            //Opgave 6:
            //Tester metoden "RegistrerReservation"

            Console.WriteLine(opgave6 + opgaveAdskillelse);
            Console.WriteLine("Test af metoden RegistrerReservation samt PrintReservationer:\n");
            Reservationer reservationer = new Reservationer();
            reservationer.RegistrerReservation(reservation1);
            reservationer.RegistrerReservation(reservation2);
            reservationer.RegistrerReservation(reservation3);
            reservationer.RegistrerReservation(reservation4);

            //Tester metoden "PrintReservatoner"
            reservationer.PrintReservationer();

            //Tester metoden "FjernReservation"
            Console.WriteLine("\nTest af metoden FjernReservation:\n");
            //reservation2 fjernes fra reservationer
            reservationer.FjerneReservation(reservation4);
            //reservationer printes
            reservationer.PrintReservationer();

            //Opgave 7:
            Console.WriteLine(opgave7 + opgaveAdskillelse);
            //Overblik over reservationer
            Console.WriteLine("Overblik over reservationer:");
            reservationer.PrintReservationer();
            //Test af metoden AntalReservationer
            int antalReservationer = reservationer.AntalReservationer(boernegruppe2);
            Console.WriteLine($"Antal reservationer for børnegruppe 2:\n{antalReservationer}");



        }
    }
}