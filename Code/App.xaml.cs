using Kontroler;
using Dtos;
using Projekat.Repozitorijum;
using Repozitorijum;
using Servis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string KORISNICI_FILE = "../../Files/korisnici.txt";
        private const string SEPARATOR = ",";
        private const string LEKOVI_FILE = "../../Files/lekovi.txt";
        private const string PRODATI_LEKOVI_FILE = "../../Files/prodati.txt";
        private const string RACUNI_FILE = "../../Files/racuni.txt";
        private const string RECEPTI_FILE = "../../Files/recepti.txt";

        public App()
        {
            var korisnikRepozitorijum = new RegistrovaniRepozitorijum(KORISNICI_FILE, SEPARATOR);
            var lekRepozitorijum = new LekRepozitorijum(LEKOVI_FILE, SEPARATOR, PRODATI_LEKOVI_FILE);
            var receptRepozitorijum = new ReceptRepozitorijum(RECEPTI_FILE, SEPARATOR);
            var racunRepozitorijum = new RacunRepozitorijum(RACUNI_FILE,SEPARATOR);



            var AdminServis = new AdminServis(korisnikRepozitorijum);
            var korisnikServis = new KorisnikServis(korisnikRepozitorijum);
            var lekServis = new LekServis(lekRepozitorijum);
            var receptServis = new ReceptServis(receptRepozitorijum);
            var racunServis = new RacunServis(racunRepozitorijum);


            AdminKontroler = new AdminKontroler(AdminServis);
            
            LekKontroler = new LekKontroler(lekServis);
            ReceptKontroler = new ReceptKontroler(receptServis);
            RacunKontroler = new RacunKontroler(racunServis);
            KorisnikKontroler = new KorisnikKontroler(korisnikServis);

            
        }
        public AdminKontroler AdminKontroler { get; private set; }
        public KorisnikKontroler KorisnikKontroler { get; private set; }

        public LekKontroler LekKontroler { get; private set; }

        public ReceptKontroler ReceptKontroler { get; private set; }

        public RacunKontroler RacunKontroler { get; private set; }
    }
}
