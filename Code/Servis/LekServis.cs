/***********************************************************************
 * Module:  PacijentKontroler.cs
 * Purpose: Definition of the Class Kontroler.PacijentKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using Repozitorijum;
using System;
using System.Collections.Generic;

namespace Servis
{
   public class LekServis
   {
        public Repozitorijum.LekRepozitorijum lekRepozitorijum;
        internal List<LekDtos> DobaviSveLekove()
      {
         
         return lekRepozitorijum.DobaviSveLekove(); ;
      }
      
     
      
      
      public LekDtos IzmeniLek(string sifraleka)
      {

           
            return lekRepozitorijum.IzmeniLek(sifraleka);
      }

        internal bool BrisanjeLekova(string sifraLeka)
        {
            return lekRepozitorijum.ObrisiLek(sifraLeka);
        }

        public Boolean DodajLekUKopru(Dictionary<string, int> korpa,int kolicina,LekDtos lek)
        {
            if (lek.Obrisan == true)
                return false;
            else if (lek.IzdajeSeNaRecetp == true)
                return false;
            else
            {
                if (korpa.ContainsKey(lek.Ime))
                {
                    korpa[lek.Ime] += kolicina;
                    return true;
                }
                else
                {
                    korpa[lek.Ime] = kolicina;
                    return true;
                }

            }

               
        }

       // public void potvrdiProdaju(Dictionary<string, int> korpa, string apotekar)
        /*{
           List<Racun> racuni = racunServis.();
            Racun racun = new Racun();
            if (racuni is null)
                racun.Sifra = 1;
            else
                racun.Sifra = racuni.Last().Sifra + 1;

            racun.Apotekar = apotekar;
            racun.Datum = DateTime.Now;
            racun.Lekovi = korpa;


            float ukupnaCena = 0;
            foreach (KeyValuePair<string, int> pair in korpa)
            {
                List<Lek> lekovi = _lekRepo.dobaviLekPoImenu(pair.Key);
                foreach (Lek lek in lekovi)
                {
                    ukupnaCena += lek.Cena * pair.Value;
                }
            }
            racun.UkupnoCena = ukupnaCena;
            Racun provera = _racunServis.kreiranjeRacuna(racun);

        }
    }

            */


        internal bool UspesnoDodavanje(LekDtos noviLek)
        {
            lekRepozitorijum.ValidanLek(noviLek);
            return true;
        }

        public LekServis(LekRepozitorijum lekRepozitorijum)
        {
            this.lekRepozitorijum = lekRepozitorijum;
        }

        internal object DodavanjeLekova(LekDtos noviLek)
        {
            return lekRepozitorijum.SacuvajLek(noviLek);

        }

        internal List<LekDtos> DobaviPoSifri(string sifra)
        {
            return lekRepozitorijum.DobaviPoSifri(sifra);
        }

        internal List<LekDtos> DobaviSveProdate()
        {
            return lekRepozitorijum.DobaviSveProdate();
        }

        internal List<LekDtos> DobaviSveProdate(string proizvodjac)
        {
            return lekRepozitorijum.DobaviSveProdate(proizvodjac);
        }
        internal List<LekDtos> DobaviSveProdateLekar(string lekar)
        {
            return lekRepozitorijum.DobaviSveProdateLekar(lekar);
        }
        


        internal List<LekDtos> DobaviPoImenu(string imeLeka)
        {
            return lekRepozitorijum.DobaviPoImenu(imeLeka);
        }

        internal List<LekDtos> DobaviPoProizvodjacu(string proizvodjac)
        {
            return lekRepozitorijum.DobaviPoProizvodjacu(proizvodjac);
        }

        internal List<LekDtos> DobaviPoCeni(string cena)
        {
            return lekRepozitorijum.DobaviPoCeni(cena);
        }
    }
}