/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Servis;
using System;
using System.Collections.Generic;

namespace Kontroler
{
   public class KorisnikKontroler
   {
        
        public KorisnikDtos PrijaviSe(String korisnikoIme, String lozinka)
        {
           try
            {
                return korisnikServis.ValidnaPrijava(korisnikoIme, lozinka);
            }
           catch (Exception e)
          {
            return null;
            }
        }

   
            
   
      public Servis.KorisnikServis korisnikServis;

        public KorisnikKontroler(KorisnikServis korisnikServis)
        {
            this.korisnikServis = korisnikServis;
        }

        internal List<KorisnikDtos> DobaviSveKorisnike()
        {
            return korisnikServis.DobaviSveKorisnike();
        }
    }
}