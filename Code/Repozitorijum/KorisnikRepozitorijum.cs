/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repozitorijum
{
   
        public class KorisnikRepozitorijum
    {
            private string _korisnici_files;
            private string _separator;

            public KorisnikRepozitorijum(string korisnici_files, string separator)
            {
                _korisnici_files = korisnici_files;
                _separator = separator;
            }

           
      
      public KorisnikDtos IzmeniKorisnika(KorisnikDtos korisnik)
      {
         // TODO: implement
         return null;
      }
      
      public List<Korisnik> [] PretraziKorisnika(string nacinPretrage)
      {
         // TODO: implement
         return null;
      }

        internal List<KorisnikDtos> DobaviSveKorisnike()
        {

            List<KorisnikDtos> korisnici = new List<KorisnikDtos>();
            foreach (var line in UcitajFajl(_korisnici_files))
            {
                string[] temp = line.Split(',').ToArray();
                korisnici.Add(ConvertStringToObject(temp));
            }
            return korisnici;
        }

        private string[] UcitajFajl(string imefajla)
        {
            string[] lines = File.ReadAllLines(imefajla).ToArray();
            return lines;
        }

        private KorisnikDtos ConvertStringToObject(string[] korisnik)
        {
            if (korisnik.Length != 0)
            {
                KorisnikDtos korisnici = new KorisnikDtos((korisnik[0]), "", (korisnik[2]),(korisnik[3]), (korisnik[4]));
                return korisnici;
            }
            else return null;
        }

    }
}