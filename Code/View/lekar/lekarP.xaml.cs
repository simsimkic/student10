using Kontroler;
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

namespace Projekat.View.lekar
{
    /// <summary>
    /// Interaction logic for lekarP.xaml
    /// </summary>
    public partial class lekarP : Window
    {
      
       
        
            private readonly LekKontroler lekKontroler;
            private readonly KorisnikKontroler korisnikKontroler;
            private readonly ReceptKontroler receptKontroler;

            public lekarP()
            {
                InitializeComponent();
                var app = Application.Current as App;
                lekKontroler = app.LekKontroler;
                korisnikKontroler = app.KorisnikKontroler;
                receptKontroler = app.ReceptKontroler;

            }


            private void PrikaziSveKorisnike(object sender, RoutedEventArgs e)
            {
                LekoviGrid.Visibility = Visibility.Hidden;
                KorisniciGrid.Visibility = Visibility.Visible;
                ReceptiGrid.Visibility = Visibility.Hidden;
                LekoviGridPretraga.Visibility = Visibility.Hidden;

                List<KorisnikDtos> listaKorisnika = new List<KorisnikDtos>();
                listaKorisnika = korisnikKontroler.DobaviSveKorisnike();



                List<KorisnikDtos> korisniciBezLozinke = new List<KorisnikDtos>();

                foreach (KorisnikDtos korisnik in listaKorisnika)
                {
                    KorisnikDtos korisnikBezLozinke = new KorisnikDtos(korisnik.KorisnickoIme, korisnik.Ime, korisnik.Prezime, korisnik.Uloga);
                    korisniciBezLozinke.Add(korisnikBezLozinke);
                }

                foreach (KorisnikDtos korisnik in korisniciBezLozinke)
                {
                    KorisniciGrid.ItemsSource = korisniciBezLozinke;
                }




            }



            private void PrikaziSveRecepte(object sender, RoutedEventArgs e)
            {
                LekoviGrid.Visibility = Visibility.Hidden;
                KorisniciGrid.Visibility = Visibility.Hidden;
                ReceptiGrid.Visibility = Visibility.Visible;
                LekoviGridPretraga.Visibility = Visibility.Hidden;

                List<ReceptDtos> listaRecepta = new List<ReceptDtos>();
                listaRecepta = receptKontroler.DobaviSveRecepte();
                foreach (ReceptDtos recept in listaRecepta)
                {
                    {

                        ReceptiGrid.ItemsSource = listaRecepta;
                    }
                }

            }





            private void PrikaziSveLekove(object sender, RoutedEventArgs e)
            {

                LekoviGrid.Visibility = Visibility.Visible;
                KorisniciGrid.Visibility = Visibility.Hidden;
                ReceptiGrid.Visibility = Visibility.Hidden;
                LekoviGridPretraga.Visibility = Visibility.Hidden;
                List<LekDtos> listaLekova = new List<LekDtos>();
                listaLekova = lekKontroler.DobaviSveLekove();
                foreach (LekDtos lek in listaLekova)
                {
                    {
                        LekoviGrid.ItemsSource = listaLekova;
                    }
                }
            }





            private void PretraziLekove(object sender, RoutedEventArgs e)
            {

                LekoviGrid.Visibility = Visibility.Hidden;
                KorisniciGrid.Visibility = Visibility.Hidden;
                ReceptiGrid.Visibility = Visibility.Hidden;
                string nacinPretrage = pretragaLeka.Text;
                string trazi = traziLek.Text;
                List<LekDtos> listaLekova = new List<LekDtos>();


                if (nacinPretrage == "Sifra")

                    listaLekova = lekKontroler.DobaviPoSifri(trazi);

                else if (nacinPretrage == "Ime")

                    listaLekova = lekKontroler.DobaviPoImenu(trazi);

                else if (nacinPretrage == "Proizvodjac")

                    listaLekova = lekKontroler.DobaviPoProizvodjacu(trazi);
                else if (nacinPretrage == "OpsegCene")
                    listaLekova = lekKontroler.DobaviPoCeni(trazi);
                else
                    MessageBox.Show("izabreti nacin pretrage");




                if (listaLekova == null) MessageBox.Show("Nepostojeca sifra.");
                else
                {
                    LekoviGridPretraga.Visibility = Visibility.Visible;

                    foreach (LekDtos lek in listaLekova)
                    {

                        LekoviGridPretraga.ItemsSource = listaLekova;

                    }



                }
            }


            private void PretraziRecepte(object sender, RoutedEventArgs e)
            {

                LekoviGrid.Visibility = Visibility.Hidden;
                KorisniciGrid.Visibility = Visibility.Hidden;
                ReceptiGrid.Visibility = Visibility.Hidden;
                LekoviGridPretraga.Visibility = Visibility.Hidden;
                string nacinPretrage = pretragaRecepta.Text;
                string trazi = traziRecept.Text;
                List<ReceptDtos> listaRecepta = new List<ReceptDtos>();


            if (nacinPretrage == "Sifra")

                listaRecepta = receptKontroler.DobaviPoSifri(trazi);

            else if (nacinPretrage == "Lekar")

                listaRecepta = receptKontroler.DobaviPoLekaru(trazi);

            else if (nacinPretrage == "Jbmg")

                listaRecepta = receptKontroler.DobaviPoJBMGu(trazi);

            else if (nacinPretrage == "Lek")
                listaRecepta = receptKontroler.DobaviPoLeku(trazi);

            else
                MessageBox.Show("izabreti nacin pretrage");




                if (listaRecepta == null) MessageBox.Show("Nepostojeca sifra.");
                else
                {
                    LekoviGridPretraga.Visibility = Visibility.Visible;

                    foreach (ReceptDtos recept in listaRecepta)
                    {

                        LekoviGridPretraga.ItemsSource = listaRecepta;

                    }



                }
            }


            private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

        

        private void kreirajrecept(object sender, RoutedEventArgs e)
        {
            kreirajRecept kr = new kreirajRecept();            
            kr.id2.Text = id.Text;
            kr.ShowDialog();
        }
    }
    }

