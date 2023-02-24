/***********************************************************************
 * Module:  RacunKontoler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontoler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Repozitorijum;
using System;
using System.Collections.Generic;

namespace Servis
{
   public class ReceptServis
   {
      

        internal List<ReceptDtos> DobaviSveLekove()
        {
            return receptRepozitorijum.DobaviSveRecepte(); ;
        }

        
      
   
   
      public Repozitorijum.ReceptRepozitorijum receptRepozitorijum;

        public ReceptServis(ReceptRepozitorijum receptRepozitorijum)
        {
            this.receptRepozitorijum = receptRepozitorijum;
        }

        internal List<ReceptDtos> DobaviPoSifri(string sifra)
        {
            return receptRepozitorijum.DobaviPoSifri(sifra);
        }

      

        internal List<ReceptDtos> DobaviPoLekaru(string lekar)
        {
            return receptRepozitorijum.DobaviPoLekaru(lekar);
        }

        internal object KreiranjeRecepta(ReceptDtos recept)
        {
            return receptRepozitorijum.SacuvajRecept(recept);
        }

        internal List<ReceptDtos> DobaviPoJBMGu(string jbmg)
        {
            return receptRepozitorijum.DobaviPoJBMGu(jbmg);

        }

        internal List<ReceptDtos> DobaviPoLeku(string lek)
        {
            return receptRepozitorijum.DobaviPoLeku(lek);

        }

        
    }
}