/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Repozitorijum;
using System;
using System.Collections.Generic;

namespace Servis
{
   public class RacunServis
   {

        public Repozitorijum.RacunRepozitorijum racunRepozitorijum;

        internal void NapraviRacun(RacunDtos racun)
        {
            racunRepozitorijum.UpisiUFajl(racun);
        }

        internal List<RacunDtos> DobaviSveLekove()
        {
            return racunRepozitorijum.DobaviSveLekove(); ;
        }

        public List<Racun>[] PrikaziSvePoApotekaru(int idApotekara)
      {
         // TODO: implement
         return null;
      }
   
      

        public RacunServis(RacunRepozitorijum racunRepozitorijum)
        {
            this.racunRepozitorijum = racunRepozitorijum;
        }
    }
}