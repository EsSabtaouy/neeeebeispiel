using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    class Program
    {
        static void Main(string[] args)
        {

            Kartenstapel startStapel = new Kartenstapel() {  Bezeichnung="startStapel"};
            //startStapel.AddCart(new Karte() {Farbe="Karo",Bezeichnung="7" } );
            startStapel.Show(1); Console.WriteLine("=======================================");
            startStapel.Show(2); Console.WriteLine("=======================================");
            startStapel.Mischen(8); startStapel.Show(3);



            // Hier ist Mein Arbeit:*********************************************
            //Karte k1 = new Karte();
            //List<string> karteliste1 = new List<string>();
            ////Stack meinspiel = k1.Sortierung();
            //k1.Teilliste(10);

            ////PrintValues(meinspiel);

            Console.ReadLine();
        }
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.WriteLine("  {0}", obj);
        }
    }
}
