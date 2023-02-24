/***********************************************************************
 * Module:  KorisnikServis.cs
 * Purpose: Definition of the Class Servis.KorisnikServis
 ***********************************************************************/

using Dtos;
using System;
using System.Collections.Generic;
using Projekat.Dtos;
using Projekat.Repozitorijum;
using Repozitorijum;

namespace Servis
{
   public class KorisnikServis
   {
        public Servis.KorisnikServis korisnikServis;
        private RegistrovaniRepozitorijum korisnikRepozitorijum;
        

        public KorisnikServis(RegistrovaniRepozitorijum korisnikRepozitorijum)
        {
            this.korisnikRepozitorijum = korisnikRepozitorijum;
        }

        public KorisnikDtos Korisnik (string korisnickoIme, string lozinka)
      {
         // TODO: implement
         return null;
      }

        internal List<KorisnikDtos> DobaviSveKorisnike()
        {
            return korisnikRepozitorijum.DobaviSveKorisnike(); ;
        }

      

        
      

        public KorisnikDtos ValidnaPrijava(string korisnickoIme, string lozinka)
        {
            return korisnikRepozitorijum.ValidanPrijavaKorisnika(korisnickoIme, lozinka);
        }

     


    }
}