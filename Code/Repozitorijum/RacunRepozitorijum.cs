/***********************************************************************
 * Module:  RacunKontroler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontroler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repozitorijum
{
    public class RacunRepozitorijum
    {
        private string _racuni_files;
        private string _separator;

        public RacunRepozitorijum(string racuni_files, string separator)
        {
            _racuni_files = racuni_files;
            _separator = separator;
        }




        internal List<RacunDtos> DobaviSveLekove()
        {
            List<RacunDtos> racuni = new List<RacunDtos>();
            foreach (var line in UcitajFajl(_racuni_files))
            {
                string[] temp = line.Split(',').ToArray();
               // racuni.Add(ConvertStringToObject(temp));
            }
            return racuni;
        }




         internal void UpisiUFajl(RacunDtos racun)
            {
                int racunID = File.ReadAllLines(_racuni_files).Length + 1;
                racun.Sifra = racunID.ToString();
                File.AppendAllText(_racuni_files, ConvertObjectToString(racun) + Environment.NewLine);

            }
    

        

            private string[] UcitajFajl(string imefajla)
            {
                string[] lines = File.ReadAllLines(imefajla).ToArray();
                return lines;
            }
        /*
            private RacunDtos ConvertStringToObject(string[] racun)
            {
                Dictionary<string, int> lek = new Dictionary<string, int>();
                lek[racun[4]] = Int32.Parse(racun[5]);

                if (racun.Length != 0)
                {
                  RacunDtos racuni = new RacunDtos(racun[0], racun[1], racun[2],racun[3],racun[4])
                        return racuni;
                }
                else return null;
            }*/

            private string ConvertObjectToString(RacunDtos racun)
            {
                var asString = string.Join(",", racun.LekoviKolicina);
                string racunString = racun.Sifra + _separator + racun.Apotekar + _separator + racun.Cena + _separator
                    + racun.Datum + _separator + asString;
                return racunString;
            }






    }
}