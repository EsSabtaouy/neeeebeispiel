﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartenSpiel
{
    class Kartenstapel
    {
        public string Bezeichnung { get; set; }
        private Stack<Karte> stapel_1 = new Stack<Karte>();
        private Stack<Karte> stapel_2 = new Stack<Karte>();
        private Stack<Karte> stapel_3;// = new Stack<Karte>();

        public Kartenstapel()
        {
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "2" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "3" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "4" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "5" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "6" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "7" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "8" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "9" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "10" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "Bube" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "Dame" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "König" });
            this.AddCart(new Karte() { Farbe = "Pik", Bezeichnung = "As" });

            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "2" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "3" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "4" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "5" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "6" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "7" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "8" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "9" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "10" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "Bube" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "Dame" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "König" });
            this.AddCart(stapel_2, new Karte() { Farbe = "Herz", Bezeichnung = "As" });


        }
        public void Show(int zahl)
        {
            if (zahl==1)
            {
                foreach (Karte karte in stapel_1)
                {
                    Console.WriteLine(karte.ToString());
                    // ohne ToString-Methode
                    //Console.WriteLine(karte.Bezeichnung + karte.Farbe);
                }
            }
            if (zahl == 2)
            {
                foreach (Karte karte in stapel_2)
                  Console.WriteLine(karte.ToString());
            }
            if (zahl == 3)
            {
                foreach (Karte karte in stapel_3)
                    Console.WriteLine(karte.ToString());
            }

        }

        public void AddCart(Karte karte)
        {
            stapel_1.Push(karte);

        }
        public void AddCart(Stack<Karte> stapel,Karte karte)
        {
            stapel.Push(karte);
        }

        private Stack<Karte> KarteFürKarte(Stack<Karte> st1 , Stack<Karte> st2) 
        {
            Stack<Karte> ergebnis= new Stack<Karte>();

            while (st1.Count>0)
            {
                ergebnis.Push(st1.Pop()); ergebnis.Push(st2.Pop());
            }
            return ergebnis;
        }
        public void Mischen(int zahl)
        {
            stapel_3 = KarteFürKarte(stapel_1, stapel_2);
            stapel_3 = Abheben(stapel_3,zahl);

        }

        private Stack<Karte> Abheben(Stack<Karte> st,int zahl)
        {
            Karte [] stA  ;
            Stack<Karte> st1 = new Stack<Karte>(), st2 = new Stack<Karte>(), st3 = new Stack<Karte>(), st4= new Stack<Karte>();
            int teiler = st.Count / zahl;
            for (int i = 0; i < teiler; i++)
            {
                st1.Push(st.Pop()); st2.Push(st.Pop()); st3.Push(st.Pop()); st4.Push(st.Pop());
            }
            

            Karte[] st1A = st1.ToArray(); Karte[] st2A = st2.ToArray(); Karte[] st3A = st3.ToArray(); Karte[] st4A = st4.ToArray();
            stA = st3A.Concat(st1A.Concat(st4A.Concat(st2A))).ToArray();

            foreach (Karte karte in stA)
                Console.WriteLine(karte.ToString());

            Console.WriteLine("=====================================================");

            return new Stack<Karte> (stA);
        }
    }
}
