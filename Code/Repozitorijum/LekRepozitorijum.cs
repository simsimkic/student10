/***********************************************************************
 * Module:  PacijentKontroler.cs
 * Purpose: Definition of the Class Kontroler.PacijentKontroler
 ***********************************************************************/

using Dtos;
using Newtonsoft.Json;
using Projekat.Dtos;
using Projekat.Greske;
using Servis;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Windows;

namespace Repozitorijum
{
    public class LekRepozitorijum
    {
        private string _lekovi_files;
        private string _separator;
        private string _prodati_files;

        public LekRepozitorijum(string lekovi_files, string separator, string prodati_files)
        {
            _lekovi_files = lekovi_files;
            _separator = separator;
            _prodati_files = prodati_files;
        }

        public List<LekDtos> DobaviSveLekove()
        {

            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_lekovi_files))
            {
                string[] temp = line.Split(',').ToArray();
                lekovi.Add(ConvertStringToObject(temp));
            }
            return lekovi;
        }



        public bool ObrisiLek(string sifraLeka)
        {
            
         
            List<LekDtos> lekovi = DobaviSveLekove();




            foreach (LekDtos lek in lekovi)
            {
                string sifra = lek.Sifra;
                if (sifra == sifraLeka && lek.Obrisan == false)
                {
                    List<String> novi_lekovi = new List<String>();
                    foreach(var line in UcitajFajl(_lekovi_files))
                    {
                       
                        string[] temp = line.Split(',').ToArray();
                        if (temp[0].Contains(sifraLeka) && sifra.Contains(temp[0]))
                        {
                            temp[5] = "True";
                            lek.Obrisan = true;
                        }
                        novi_lekovi.Add(String.Join(",", temp));
                        
                        
                    }

                    File.WriteAllLines(_lekovi_files, novi_lekovi);
                    return true;
                }

            }
            
                return false;

            



         
        }
          
            

   

        internal void ValidanLek(LekDtos noviLek)
        {
            LekDtos lek = DobaviPoSifriLeka(noviLek.Sifra);
            if (lek != null)
            {
                throw new LekPostoji("Postoji lek sa tom sifrom");
            }
        }

        private LekDtos DobaviPoSifriLeka(string sifra)
        {
            LekDtos lek = NadjiLek(sifra);
            return lek;
        }

        public List<LekDtos> DobaviSveProdate()
        {
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_prodati_files))
            {
                string[] temp = line.Split(',').ToArray();
                LekDtos l = ConvertStringToObject(temp);
                lekovi.Add(ConvertStringToObject(temp));
                
            }
            return lekovi;

        }

        public List<LekDtos> DobaviSveProdate(string proizvodjac)
        {
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_prodati_files))
            {
                string[] temp = line.Split(',').ToArray();
                LekDtos l = ConvertStringToObject(temp);
                if (String.Equals(l.Proizvodjac, proizvodjac))
                    lekovi.Add(ConvertStringToObject(temp));

            }
            return lekovi;

        }

        public List<LekDtos> DobaviSveProdateLekar(string lekar)
        {
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_prodati_files))
            {
                string[] temp = line.Split(',').ToArray();
                if (String.Equals(temp[6], lekar))
                    lekovi.Add(ConvertStringToObject(temp));

            }
            return lekovi;

        }

        private LekDtos NadjiLek(string sifra)
        {
            return NadjiLekPoSifri(sifra, UcitajFajl(_lekovi_files));

        }

        private LekDtos NadjiLekPoSifri(string sifra, string[] lines)
        {
            if (lines.Length != 0)
            {
                foreach (var line in lines)
                {
                    string[] entries = line.Split(',');
                    if (sifra == entries[0]) return ConvertStringToObject(entries);
                }
            }
            return null;
        }


        public LekDtos IzmeniLek(string sifraleka)
        {
            //LekDtos lek = Nadjilek(sifraleka);
            //LekDtos noviLek =lek.Sifra + _separator ;
            return null;
        }

        internal LekDtos SacuvajLek(LekDtos noviLek)
        {
            UpisiUFajl(noviLek);
            return noviLek;
        }

        private void UpisiUFajl(LekDtos noviLek)
        {
            int lekID = File.ReadAllLines(_lekovi_files).Length + 1;
            File.AppendAllText(_lekovi_files, ConvertObjectToString(noviLek) + Environment.NewLine);

        }


        private string ConvertObjectToString(LekDtos noviLek)
        {
            string lekString = noviLek.Sifra + _separator + noviLek.Ime + _separator + noviLek.Proizvodjac + _separator +
            noviLek.Cena + _separator + noviLek.IzdajeSeNaRecetp + _separator + noviLek.Obrisan;
            return lekString;
        }


        internal List<LekDtos> DobaviPoSifri(string sifra)
        {
            List<LekDtos> lekovi = new List<LekDtos>();

            foreach (var line in UcitajFajl(_lekovi_files))
            {
                string[] temp = line.Split(',').ToArray();
                if (temp[0] == sifra)
                    lekovi.Add(ConvertStringToObject(temp));
            }
                return lekovi;
            
        }

        internal List<LekDtos> DobaviPoCeni(string cena)
        {
            float uporedi = (float)Convert.ToDouble(cena);
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_lekovi_files))
            {
                string[] temp = line.Split(',').ToArray();
                float cen = (float)Convert.ToDouble(temp[3]);
                if (cen <= uporedi)
                    lekovi.Add(ConvertStringToObject(temp));
            }
                return lekovi;

            }
            
            
            

        internal List<LekDtos> DobaviPoProizvodjacu(string proizvodjac)
        {
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_lekovi_files))
            {
                string[] temp = line.Split(',').ToArray();
                string proizv = proizvodjac.ToLower();
                string imena = temp[2].ToLower();
                if (imena.Contains(proizv))                
                    lekovi.Add(ConvertStringToObject(temp));

            }
                return lekovi;

            }


           

        internal List<LekDtos> DobaviPoImenu(string imeLeka)
        {
            List<LekDtos> lekovi = new List<LekDtos>();
            foreach (var line in UcitajFajl(_lekovi_files))
            {
                string[] temp = line.Split(',').ToArray();
                string provera = temp[1]; 
                if (provera.ToLower().Contains(imeLeka))
                    lekovi.Add(ConvertStringToObject(temp)); }
                return lekovi;

            }
            

        private string[] UcitajFajl(string imefajla)
        {
            string[] lines = File.ReadAllLines(imefajla).ToArray();
            return lines;
        }

        private LekDtos ConvertStringToObject(string[] lek)
        {
            if (lek.Length != 0)
            {
                LekDtos lekovi = new LekDtos(lek[0], lek[1], lek[2], float.Parse(lek[3]), bool.Parse(lek[4]), bool.Parse(lek[5]));
                return lekovi;
            }
            else return null;
        }

    }

}