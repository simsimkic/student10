using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projekat.Dtos
{
    public class KorisnikDtos
    {
        private string korisnickoIme;
        private string lozinka;
        private string ime;
        private string prezime;
        private string uloga;

        

        public KorisnikDtos(string korisnickoIme, string lozinka, string ime, string prezime, string uloga)
        {
            this.korisnickoIme = korisnickoIme;
            this.lozinka = lozinka;
            this.ime = ime;
            this.prezime = prezime;
            this.uloga = uloga;
        }

        public KorisnikDtos (string korisnickoIme, string ime, string prezime, string uloga)
        {
            this.korisnickoIme = korisnickoIme;
            this.ime = ime;
            this.prezime = prezime;
            this.uloga = uloga;
        }
      
        public string KorisnickoIme
        {
            get { return korisnickoIme; }
            set { korisnickoIme = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Uloga
        {
            get { return uloga; }
            set { uloga = value; }
        }

        public string Lozinka
        {
            get { return lozinka;            }
            set { lozinka = value; }
        }

    }

}
