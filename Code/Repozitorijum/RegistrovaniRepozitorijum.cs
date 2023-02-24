using Projekat.Dtos;
using Projekat.Greske;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Projekat.Repozitorijum
{
    public class RegistrovaniRepozitorijum
    {
        private string _korisnici_files;
        private string _separator;
        private string _ulogovan;

        public RegistrovaniRepozitorijum(string korisnici_files, string separator)
        {
            _korisnici_files = korisnici_files;
            _separator = separator;
        }

        public KorisnikDtos Kreiraj(KorisnikDtos entity)
        {
            return SacuvajKorisnika(entity);
        }

        public void ValidanKorisnik(KorisnikDtos noviKorisnik)
        {
            KorisnikDtos korisnik= NadjipoImenu(noviKorisnik.KorisnickoIme);
            if (korisnik != null)
            {
                throw new ImeVecPostoji("Postoji korisnik sa tim imenom");
            }
        }

        

        public KorisnikDtos ValidanPrijavaKorisnika(string korisnickoIme, string lozinka)
        {
           KorisnikDtos korisnik = NadjipoImenu(korisnickoIme);
            if (korisnik == null) { throw new PogresnoIme("Uneli ste pogresno ime"); }

            else if (korisnik.Lozinka != lozinka) throw new PogresnaLozinka("Pogresna lozinka");
            else
            {   
                return korisnik;
            }
        }

        public KorisnikDtos SacuvajKorisnika(KorisnikDtos noviKorisnik)
        {
            UpisiUFajl(noviKorisnik);
            return noviKorisnik;
        }

        private void UpisiUFajl(KorisnikDtos noviKorisnik)
        {
            int korisnikID = File.ReadAllLines(_korisnici_files).Length + 1;
            File.AppendAllText(_korisnici_files, ConvertObjectUserToString(noviKorisnik) + Environment.NewLine);

        }

        private string ConvertStringToObject(KorisnikDtos noviKorisnik)
        {
            string korisnikString = noviKorisnik.KorisnickoIme + _separator + noviKorisnik.Lozinka + _separator + noviKorisnik.Ime + _separator +
            noviKorisnik.Prezime + _separator + noviKorisnik.Uloga;
            return korisnikString;
        }

        private string ConvertObjectUserToString(KorisnikDtos noviKorisnik)
        {
            string korisnikString = noviKorisnik.KorisnickoIme + _separator + noviKorisnik.Lozinka + _separator + noviKorisnik.Ime + _separator +
            noviKorisnik.Prezime + _separator + noviKorisnik.Uloga;
            return korisnikString;
        }


        private KorisnikDtos NadjipoImenu(string korisnickoIme)
        {
            KorisnikDtos korisnik = NadjiKorisnika(korisnickoIme);
            return korisnik;
        }
        private KorisnikDtos NadjiKorisnika(string korisnickoIme)
        {
            return NadjiKorisnikaPoImenu(korisnickoIme, ReadFile(_korisnici_files));
        }

        public string[] ReadFile(string _korisnici_files)
        {
            string[] lines = File.ReadAllLines(_korisnici_files).ToArray();
            return lines;
        }

        public KorisnikDtos NadjiKorisnikaPoImenu(string korisnickoIme, string[] lines)
        {
            if (lines.Length != 0)
            {
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    if (korisnickoIme == entries[0]) return ConvertStringToObject(entries);
                }
            }
            return null;
        }

        private KorisnikDtos ConvertStringToObject(string[] korisnici)
        {
            KorisnikDtos korisnik = new KorisnikDtos(korisnici[0], korisnici[1], korisnici[2], korisnici[3], korisnici[4]);
            return korisnik;
        }

        internal List<KorisnikDtos> DobaviSveKorisnike()
        {

            List<KorisnikDtos> korisnici = new List<KorisnikDtos>();
            foreach (var line in UcitajFajl(_korisnici_files))
            {
                string[] temp = line.Split(',').ToArray();
                korisnici.Add(ConvertStringToObject1(temp));
            }
            return korisnici;
        }

        private string[] UcitajFajl(string imefajla)
        {
            string[] lines = File.ReadAllLines(imefajla).ToArray();
            return lines;
        }

        private KorisnikDtos ConvertStringToObject1(string[] korisnik)
        {
            if (korisnik.Length != 0)
            {
                KorisnikDtos korisnici = new KorisnikDtos((korisnik[0]), (korisnik[1]), (korisnik[2]), (korisnik[3]), (korisnik[4]));
                return korisnici;
            }
            else return null;
        }


    }
}
