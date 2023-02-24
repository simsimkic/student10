using Kontroler;
using Dtos;
using Projekat.Dtos;
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
using System.Windows.Shapes;

namespace Projekat.View
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        private readonly AdminKontroler adminKontroler;
        public Registracija()
        {
            InitializeComponent();
            var app = Application.Current as App;
            adminKontroler = app.AdminKontroler;
        }

        private void RegistracijaNastavak(object sender, RoutedEventArgs e)
        {
            if (PraznaPolja())
            {

                KorisnikDtos noviKorisnik = RegistracijaKorisnika();
              
                if (adminKontroler.Registracija(noviKorisnik)==null) MessageBox.Show("Ime vec postoji");
              else

                {
                    Pocenta log = new Pocenta();
                    this.Close();
                    log.Show();
                }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public KorisnikDtos RegistracijaKorisnika()
        {
            string korisnickoIme = korImeText.Text;
            string lozinka = LozinkaText.Password;
            string ime = ImeText.Text;
            string prezime = PrezimeText.Text;
            string uloga = combo.Text;

            return new KorisnikDtos (korisnickoIme, lozinka, ime, prezime,uloga);
        }

        public bool PraznaPolja()
        {
            if (ImePrazno()) return false;
            if (PrezimePrazno()) return false;
            if (LozinkaPrazno()) return false;
            if (KorisnickoImePrazno()) return false;
            if (UlogaPrazno()) return false;
          
            return true;
        }

        public bool KorisnickoImePrazno()
        {
            if (korImeText.Text == "")
            {
                MessageBox.Show("Unesite korisniko ime");
                return true;
            }
            return false;
        }

        public bool LozinkaPrazno()
        {
            if (LozinkaText.Password == "")
            {
                MessageBox.Show("Unesite lozinku");
                return true;
            }
            return false;
        }

        public bool PrezimePrazno()
        {
            if (PrezimeText.Text == "")
            {
                MessageBox.Show("Unesite prezime");
                return true;
            }
            return false;
        }

        public bool ImePrazno()
        {
            if (ImeText.Text == "")
            {
                MessageBox.Show("Unesite ime");
                return true;
            }
            return false;
        }

        public bool UlogaPrazno()
        {
            if (combo.Text == "")
            {
                MessageBox.Show("Izaberite ulogu");
                return true;
            }
            return false;
        }



        private void sifra_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
