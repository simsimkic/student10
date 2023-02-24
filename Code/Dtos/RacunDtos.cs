using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projekat.Dtos
{
    public class RacunDtos
    {
        private string sifra;
        private string apotekar;
        private float cena;
        private string datum;
        private Dictionary<string, String> lekoviKolicina;

        public RacunDtos(string sifra, string apotekar, float cena, string datum, Dictionary<string, string> lekoviKolicina)
        {
            this.sifra = sifra;
            this.apotekar = apotekar;
            this.cena = cena;
            this.datum = datum;
            this.lekoviKolicina = lekoviKolicina;
        }
        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public string Apotekar
        {
            get { return apotekar; }
            set { apotekar = value; }
        }
        public float Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public Dictionary<string, string> LekoviKolicina
        {
            get { return lekoviKolicina; }
            set { lekoviKolicina = value; }
        }
    }
}
