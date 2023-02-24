/***********************************************************************
 * Module:  RacunKontoler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontoler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Servis;
using System;
using System.Collections.Generic;

namespace Kontroler
{
   public class ReceptKontroler
   {
      public List<ReceptDtos> DobaviSveRecepte()
      {
            return receptServis.DobaviSveLekove();
        }
      
      
      
   
      public Servis.ReceptServis receptServis;

        public ReceptKontroler(ReceptServis receptServis)
        {
            this.receptServis = receptServis;
        }

        internal List<ReceptDtos> DobaviPoSifri(string sifra)
        {
            return receptServis.DobaviPoSifri(sifra);
        }

      
     
        internal List<ReceptDtos> DobaviPoLekaru(string lekar)
        {
            return receptServis.DobaviPoLekaru(lekar);
        }

        internal object KreiranjeRecepta(ReceptDtos recept)
        {
            return receptServis.KreiranjeRecepta(recept);
        }

        internal List<ReceptDtos> DobaviPoJBMGu(string jbmg)
        {
            return receptServis.DobaviPoJBMGu(jbmg);

        }

        internal List<ReceptDtos> DobaviPoLeku(string lek)
        {
            return receptServis.DobaviPoLeku(lek);
              }

      
    }
}