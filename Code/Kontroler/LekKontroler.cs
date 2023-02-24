/***********************************************************************
 * Module:  PacijentKontroler.cs
 * Purpose: Definition of the Class Kontroler.PacijentKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Servis;
using System;
using System.Collections.Generic;
using System.Windows.Controls;
using Xceed.Wpf.Toolkit;

namespace Kontroler
{
   public class LekKontroler
   {
      public List<LekDtos> DobaviSveLekove()
      {
         
         return lekServis.DobaviSveLekove();
      }
      
      
      
      public bool BrisanjeLekova(string sifraLeka)
      {
         
         return lekServis.BrisanjeLekova(sifraLeka);
      }
      
      
      
      public LekDtos IzmeniLek(string sifraleka)
      {

            return lekServis.IzmeniLek(sifraleka);
                }

        public void ProdajLek(Dictionary<string, int> korpa, string apotekar)
        {
    //        lekServis.ProdajLek(korpa, apotekar);

        }


        internal object DodavanjeLekova(LekDtos noviLek)
        {

            try
            {
                lekServis.UspesnoDodavanje(noviLek);
            }
            catch (Exception e)
            {

                return null;
            }
            return lekServis.DodavanjeLekova(noviLek);
        }
    

        public Servis.LekServis lekServis;

        public LekKontroler(LekServis lekServis)
        {
            this.lekServis = lekServis;
        }

        internal List<LekDtos> DobaviPoSifri(string sifra)
        {
            return lekServis.DobaviPoSifri(sifra);
        }

        internal List<LekDtos> DobaviSveProdate()
        {
            return lekServis.DobaviSveProdate();
        }
        internal List<LekDtos> DobaviSveProdate(string proizvodjac)
        {
            return lekServis.DobaviSveProdate(proizvodjac);
        }

        internal List<LekDtos> DobaviSveProdateLekar(string lekar)
        {
            return lekServis.DobaviSveProdateLekar(lekar);
        }

        internal List<LekDtos> DobaviPoImenu(string imeLeka)
        {
            return lekServis.DobaviPoImenu(imeLeka);
        }

        internal List<LekDtos> DobaviPoProizvodjacu(string proizvodjac)
        {
            return lekServis.DobaviPoProizvodjacu(proizvodjac);

        }

        internal List<LekDtos> DobaviPoCeni(string cena)
        {
            return lekServis.DobaviPoCeni(cena);
        }
    }
}
