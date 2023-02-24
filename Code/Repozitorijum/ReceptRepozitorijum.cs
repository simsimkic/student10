/***********************************************************************
 * Module:  RacunKontoler.cs
 * Purpose: Definition of the Class Kontroler.RacunKontoler
 ***********************************************************************/

using Dtos;
using Projekat.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media.Animation;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Repozitorijum
{
    public class ReceptRepozitorijum
    {
        private string _recepti_files;
        private string _seprator;

        public ReceptRepozitorijum(string recepti_files, string seprator)
        {
            _recepti_files = recepti_files;
            _seprator = seprator;
        }

        internal List<ReceptDtos> DobaviSveRecepte()
        {
            List<ReceptDtos> recepti = new List<ReceptDtos>();
            foreach (var line in UcitajFajl(_recepti_files))
            {
                var recept = JsonConvert.DeserializeObject<ReceptDtos>(line);
                recepti.Add(recept);
            }

            return recepti;
        }
           
        internal List<ReceptDtos> DobaviPoSifri(string sifra)
        {
            List<ReceptDtos> recepti = new List<ReceptDtos>();

            foreach (var line in UcitajFajl(_recepti_files))
            {
                var recept = JsonConvert.DeserializeObject<ReceptDtos>(line);
                if (String.Equals(recept.Sifra, sifra))
                    recepti.Add(recept);
            }

            return recepti; 
            
        }

        internal ReceptDtos SacuvajRecept(ReceptDtos recept)
        { 
            UpisiUFajl(recept);
            return recept;
        }

        private void UpisiUFajl(ReceptDtos recept)
        {
            int receptID = File.ReadAllLines(_recepti_files).Length + 1;
            recept.Sifra = receptID.ToString();
            File.AppendAllText(_recepti_files, JsonConvert.SerializeObject(recept) + Environment.NewLine);
        }

        internal List<ReceptDtos> DobaviPoLeku(string lek)
        {

            List<ReceptDtos> recepti = new List<ReceptDtos>();

            foreach (var line in UcitajFajl(_recepti_files))
            {
                string[] temp = line.Split(',').ToArray();
                string imena = temp[4];
                if (imena.ToLower().Contains(lek))
                    recepti.Add(ConvertStringToObject(temp));
            }
            return recepti;
        }

        internal List<ReceptDtos> DobaviPoJBMGu(string jbmg)
        {

            List<ReceptDtos> recepti = new List<ReceptDtos>();

            foreach (var line in UcitajFajl(_recepti_files))
            {
                string[] temp = line.Split(',').ToArray();
                if ((temp[2]) == jbmg)
                    recepti.Add(ConvertStringToObject(temp));
            }
            return recepti;
        }

        internal List<ReceptDtos> DobaviPoLekaru(string lekar)
        {

            List<ReceptDtos> recepti = new List<ReceptDtos>();

            foreach (var line in UcitajFajl(_recepti_files))
            {
                string[] temp = line.Split(',').ToArray();
                string imena = temp[1];
                if (imena.ToLower().Contains(lekar))
                    recepti.Add(ConvertStringToObject(temp));
            }
            return recepti;

        }

       
       

        public List<Recept> PretraziRecepte(string nacinPretrage)
        {
            // TODO: implement
            return null;
        }
        private string[] UcitajFajl(string imefajla)
        {
            string[] lines = File.ReadAllLines(imefajla).ToArray();
            return lines;
        }
        



        private ReceptDtos ConvertStringToObject(string[] recept)
        {

            Dictionary<string, string> lek = new Dictionary<string, string>();
            lek[recept[4]] = recept[5];
            

            if (recept.Length != 0)
            {

                ReceptDtos recepti = new ReceptDtos(recept[0], recept[1], recept[2], recept[3], lek) ;
                return recepti;
            }
            else return null;

        }
        private string ConvertObjectToString(ReceptDtos recept)
        {
            string receptString = recept.Sifra + _seprator + recept.Lekar + _seprator + recept.JbmgPacijenta + _seprator
                + recept.Datum + _seprator + recept.Recepti.Keys + _seprator + recept.Recepti.Values;
            return receptString;
        }








    }
}
