using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Projekat.Dtos
{
    public class LekDtos
    {
        private string sifra;
        private string ime;
        private string proizvodjac;
        private float cena;
        private bool izdajeSeNaRecetp;
        private bool obrisan;

        public LekDtos(string sifra, string ime, string proizvodjac, float cena, bool izdajeSeNaRecetp,bool obrisan)
        {
            this.sifra = sifra;
            this.ime = ime;
            this.proizvodjac = proizvodjac;
            this.cena = cena;
            this.izdajeSeNaRecetp = izdajeSeNaRecetp;
            this.obrisan = obrisan;
    }


        

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Proizvodjac
        {
            get { return proizvodjac; }
            set { proizvodjac = value; }
        }
        public float Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public bool IzdajeSeNaRecetp
        {
            get { return izdajeSeNaRecetp; }
            set { izdajeSeNaRecetp = value; }
        }

        public bool Obrisan
        {
            get { return obrisan; }
            set { obrisan = value; }
        }

    }
}
