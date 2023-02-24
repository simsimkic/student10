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
   public class RacunKontroler
   {
      public void NapraviRacun(RacunDtos racun)
      {
            racunServis.NapraviRacun(racun);
      }
      
      public List<Racun>[] PrikaziSveRacune(string tipIzvestaja)
      {
         // TODO: implement
         return null;
      }
      
      public List<Racun>[] PrikaziSvePoApotekaru(int idApotekara)
      {
         // TODO: implement
         return null;
      }
   
      public Servis.RacunServis racunServis;

        public RacunKontroler(RacunServis racunServis)
        {
            this.racunServis = racunServis;
        }
    }
}