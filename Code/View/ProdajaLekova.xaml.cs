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
    /// Interaction logic for ProdajaLekova.xaml
    /// </summary>
    public partial class ProdajaLekova : Window
    {

        private readonly LekKontroler lekKontroler;
        private readonly KorisnikKontroler korisnikKontroler;
        private readonly ReceptKontroler receptKontroler;
        private readonly RacunKontroler racunKontroler;

        public ProdajaLekova()
        {
            InitializeComponent();
            var app = Application.Current as App;
            receptKontroler = app.ReceptKontroler;
            lekKontroler = app.LekKontroler;
            racunKontroler = app.RacunKontroler;

        }

        private void DodajLek(object sender, RoutedEventArgs e)
        {

            string lekSifra = Lek.Text;
            string kolicina = KolicinaLeka.Text;
            List<LekDtos> trazeni = new List<LekDtos>();
            trazeni = lekKontroler.DobaviPoSifri(lekSifra);
            List<LekDtos> korpa = new List<LekDtos>();
            if (korpa == null) MessageBox.Show("Nepostojeca sifra.");
            else
            {
                System.Collections.ArrayList items = (System.Collections.ArrayList)KopraGrid.ItemsSource != null ? (System.Collections.ArrayList)KopraGrid.ItemsSource : new System.Collections.ArrayList();

                foreach (LekDtos lek in trazeni)
                {
                    for(int i = 0; i < Int32.Parse(kolicina); i++)
                    {
                        items.Add(lek);
                    }
                }
                KopraGrid.ItemsSource = items;
                KopraGrid.Items.Refresh();
             }


            }

        

        private void DodajRecept(object sender, RoutedEventArgs e)
        {
           
            string trazi = Recept.Text;
            List<ReceptDtos> korpa = new List<ReceptDtos>();
            korpa = receptKontroler.DobaviPoSifri(trazi);
            if (korpa == null) MessageBox.Show("Nepostojeca sifra.");
            else
            {
                string sifra;
                List<LekDtos> trazeni = new List<LekDtos>();
                System.Collections.ArrayList items = (System.Collections.ArrayList)KopraGrid.ItemsSource != null ? (System.Collections.ArrayList)KopraGrid.ItemsSource : new System.Collections.ArrayList();
                foreach(ReceptDtos recept in korpa)
                {
                    sifra = recept.Recepti.Values.First();
                    trazeni = lekKontroler.DobaviPoSifri(sifra);
                    foreach (LekDtos lek in trazeni)
                    {
                        items.Add(lek);
                    }
                }
                KopraGrid.ItemsSource = items;
                KopraGrid.Items.Refresh();

            }



        }



        private void ProdajLek(object sender, RoutedEventArgs e)
        {
            float ukupna_cena = 0;
            System.Collections.ArrayList items = (System.Collections.ArrayList)KopraGrid.ItemsSource != null ? (System.Collections.ArrayList)KopraGrid.ItemsSource : new System.Collections.ArrayList();
            Dictionary<string, string> items_racun = new Dictionary<string, string>();
            foreach (LekDtos item in items)
            {
                ukupna_cena += item.Cena;
                items_racun[item.Ime] = item.Cena.ToString();
            }
            
            DateTime thisDay = DateTime.Today;
            RacunDtos racun = new RacunDtos("0", id2.Text, ukupna_cena, thisDay.ToString(), items_racun);
            racunKontroler.NapraviRacun(racun);
            MessageBox.Show("Kupovina lekova uspesna, ukupna cena " + ukupna_cena.ToString() + "  dinara.");
            this.Close();
        }

        private void KolicinaLeka_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}