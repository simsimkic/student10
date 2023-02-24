using Kontroler;
using Dtos;
using Projekat.Dtos;
using Projekat.View;
using Projekat.View.apotekar;
using Projekat.View.lekar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KorisnikKontroler korisnikKontroler;
        public int i;

        public MainWindow()
        {
            InitializeComponent();
            var app = Application.Current as App;
            korisnikKontroler = app.KorisnikKontroler;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KorisnikDtos korisnik = korisnikKontroler.PrijaviSe(ime.Text, sif.Password);
            
            if (korisnik == null)
            {
                MessageBox.Show("Pogresno ime ili lozinka");
                i=i+1;
                if (i > 3)
                    this.Close();
            }
            


            else PreusmeriKorisnika(korisnik);
        }

        

        public bool PraznaPolja()
        {
            
            if (LozinkaPrazno()) return false;
            if (KorisnickoImePrazno()) return false;

            return true;
        }
        public bool KorisnickoImePrazno()
        {
            if (ime.Text == "")
            {
                MessageBox.Show("Unesite korisniko ime");
                return true;
            }
            return false;
        }

        public bool LozinkaPrazno()
        {
            if (sif.Password == "")
            {
                MessageBox.Show("Unesite lozinku");
                return true;
            }
            return false;
        }


        public void PreusmeriKorisnika(KorisnikDtos korisnik)
        {
            if (korisnik.Uloga == "Lekar") LekarPocetna(korisnik);
            
                    
                    
                    
            else if (korisnik.Uloga == "Apotekar") ApotekarPocenta(korisnik);

            else AdminPocetna();
        }

        

        public void AdminPocetna()
        {
            Pocenta pocenta= new Pocenta();
            this.Close();
            pocenta.Show();
        }

        public void ApotekarPocenta(KorisnikDtos korisnik)
        {
            apotekarP a = new apotekarP();
            this.Close();
            a.Show();
            a.id.Text = korisnik.KorisnickoIme;

        }

        public void LekarPocetna(KorisnikDtos korisnik)
        {
            lekarP l = new lekarP();

            this.Close();
            l.Show();
            l.id.Text = korisnik.KorisnickoIme;
        }
    }
}

