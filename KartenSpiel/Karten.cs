using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    class Karten
    {
        private List<string> wertkaro = new List<string>() { "2 Karo", "3 Karo", "4 Karo", "5 Karo", "6 Karo", "7 Karo", "8 Karo", "9 Karo", "10 Karo", "Bauer Karo", "Dame Karo", "König Karo", "As Karo" };
        private List<string> wertkreuz = new List<string>() { "2 Kreuz", "3 Kreuz", "4 Kreuz", "5 Kreuz", "6 Kreuz", "7 Kreuz", "8 Kreuz", "9 Kreuz", "10 Kreuz", "Bauer Kreuz", "Dame Kreuz", "König Kreuz", "As Kreuz" };
        private List<string> wertPik = new List<string>() { "2 Pik", "3 Pik", "4 Pik", "5 Pik", "6 Pik", "7 Pik", "8 Pik", "9 Pik", "10 Pik", "Bauer Pik", "Dame Pik", "König Pik", "As Pik" };
        private List<string> wertherz = new List<string>() { "2 Herz", "3 Herz", "4 Herz", "5 Herz", "6 Herz", "7 Herz", "8 Herz", "9 Herz", "10 Herz", "Bauer Herz", "Dame Herz", "König Herz", "As Herz" };
       
        public Stack Sortierung()
        {
            Stack ergebnis = new Stack(); Stack S1= new Stack(); Stack S2 = new Stack(); Stack S3 = new Stack(); Stack S4 = new Stack();
           
            for (int i = 0; i < wertkaro.Count; i++)
            {
                S1.Push(wertkaro[i]); S2.Push(wertherz[i]); S3.Push(wertkreuz[i]); S4.Push(wertPik[i]);
                //Console.WriteLine(S1.Peek()); Console.WriteLine(S2.Peek());
            }
            //Console.WriteLine(S1.Pop());
            //Console.WriteLine(S2.Pop());
            for (int i = 0; i < wertkaro.Count; i++)
            {
                ergebnis.Push(S1.Pop()); ergebnis.Push(S2.Pop()); ergebnis.Push(S3.Pop()); ergebnis.Push(S4.Pop());
                /*Console.WriteLine(ergebnis.Peek());*/
            }
            
            return ergebnis;
        }
        public Stack Teilliste(int zahl)
        {
            Stack teilung = new Stack();
            int teiler = 52 / zahl;
            
            while (teilung.Count <  52)
            {
                int j = 0;
                Console.WriteLine("Die {0}. Liste: ",j);
                for (int i = 0; i < 6; i++)
                {
                    teilung.Push(Sortierung().Pop());
                    Console.WriteLine(teilung.Peek());
                }
                //Console.WriteLine(teilung.Peek());
                j++;
            }
            return teilung;
        }
       
    }
}
