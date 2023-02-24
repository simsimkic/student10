/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Projekat.Repozitorijum;
using Servis;
using System;
using System.Collections.Generic;

namespace Kontroler
{
   public class AdminKontroler
   {
      public KorisnikDtos Registracija(KorisnikDtos noviKorisnik)
      {
         try
            {
                adminServis.ValidnaRegistracija(noviKorisnik);
            }
            catch (Exception e)
            {

                return null;
            }
            return adminServis.Registracija(noviKorisnik);
      }
      
      public List<Racun>[] KreirajIzvestaj(string tipIzvestaja)
      {
         // TODO: implement
         return null;
      }
   
      public Servis.AdminServis adminServis;

        public AdminKontroler(AdminServis adminServis)
        {
            this.adminServis = adminServis;
        }
        
        
    }
}