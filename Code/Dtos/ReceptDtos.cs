using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Projekat.Dtos
{
    public class ReceptDtos
    {
        private string sifra;
        private string lekar;
        private string jbmgPacijenta;
        private string datum;
        private Dictionary<string, string> recepti;
        
        

        public ReceptDtos(string sifra, string lekar, string jbmgPacijenta, string datum, Dictionary<string,string> recepti)
        {
            this.sifra = sifra;
            this.lekar = lekar;
            this.jbmgPacijenta = jbmgPacijenta;
            this.datum = datum;
            this.recepti = recepti;
            
        }

        

        public string Sifra
        {
            get { return sifra; }
            set { sifra = value; }
        }
        public string Lekar
        {
            get { return lekar; }
            set { lekar = value; }
        }
        public string JbmgPacijenta
        {
            get { return jbmgPacijenta; }
            set { jbmgPacijenta = value; }
        }
        public string Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public Dictionary<string,string> Recepti
        {
            get { return recepti; }
            set { recepti = value; }
        }
        
    }
}
