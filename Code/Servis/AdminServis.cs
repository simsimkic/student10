/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Projekat.Repozitorijum;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace Servis
{
   public class AdminServis
        
   {
        public RegistrovaniRepozitorijum registrovaniRepozitorijum;

        public AdminServis(RegistrovaniRepozitorijum rk)
        {
            registrovaniRepozitorijum = rk;
        }

        public KorisnikDtos Registracija(KorisnikDtos noviKorisnik)
      {
            return registrovaniRepozitorijum.SacuvajKorisnika(noviKorisnik);   
      }

        public bool ValidnaRegistracija(KorisnikDtos noviKorisnik)
        {
           
            registrovaniRepozitorijum.ValidanKorisnik(noviKorisnik);
            return true;     
        }

     //   public string ValidnaPrijava(string korisnickoime,string lozinka)
      //  {
      //      return registrovaniRepozitorijum.ValidanPrijavaKorisnika(korisnickoime, lozinka);
            
      //  }




        public List<Racun>[] KreirajIzvestaj(string tipIzvestaja)
      {
         // TODO: implement
         return null;
      }
   
      

        

     

        
    }
}