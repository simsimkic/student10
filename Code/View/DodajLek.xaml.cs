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

namespace Projekat.View
{
    /// <summary>
    /// Interaction logic for DodajLek.xaml
    /// </summary>
    public partial class DodajLek : Window
    {
        private readonly LekKontroler lekKontroler;
        public DodajLek()
        {
            InitializeComponent();
            var app = Application.Current as App;
            lekKontroler = app.LekKontroler;
        }

        private void RegistracijaNastavak(object sender, RoutedEventArgs e)
        {
            if (PraznaPolja())
            {

                LekDtos noviLek = DodavanjeLeka();

                if (lekKontroler.DodavanjeLekova(noviLek) == null) MessageBox.Show("Lek sa istom sifrom vec postoji");
                else

                {
                    MessageBox.Show("Lek je uspesno dodat.");
                    this.Close();
                    
                }
            }

        }
        public bool PraznaPolja()
        {
            if (ImePrazno()) return false;
            if (ProizvodjacPrazno()) return false;
            if (SifraPrazno()) return false;
            if (CenaPrazno()) return false;
            if (ReceptPrazno()) return false;


            return true;
        }

        public LekDtos DodavanjeLeka()
            {
                string sifra = SifraText.Text;
                string ime = ImeText.Text;
                string proizvodjac = ProizvodjacText.Text;
                float cenaproizvoda = (float)Convert.ToDouble(cenaText.Text);
                string cena = cenaproizvoda.ToString();
                string recept = combo.Text;
                bool obrisan = false;           

                return new LekDtos(sifra, ime, proizvodjac, (float)Convert.ToDouble(cena),(bool.Parse(recept)),obrisan);
            }




        public bool SifraPrazno()
        {
            if (SifraText.Text == "")
            {
                MessageBox.Show("Unesite sifru leka");
                return true;
            }
            return false;
        }




        public bool CenaPrazno()
        {
            if (cenaText.Text == "")
            {
                MessageBox.Show("Unesite cenu");
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



        public bool ProizvodjacPrazno()
        {
            if (ProizvodjacText.Text == "")
            {
                MessageBox.Show("Unesite ime proizvodjaca");
                return true;
            }
            return false;
        }


        public bool ReceptPrazno()
        {
            if (combo.Text == "")
            {
                MessageBox.Show("Unesite da li se lek izadaje na recept");
                return true;
            }
            return false;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

