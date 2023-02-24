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
    /// Interaction logic for kreirajRecept.xaml
    /// </summary>
    public partial class kreirajRecept : Window
    {
        private readonly ReceptKontroler receptKontroler;

        public kreirajRecept()
        {
            InitializeComponent();
            var app = Application.Current as App;
            receptKontroler = app.ReceptKontroler;
        }

        private void RegistracijaNastavak(object sender, RoutedEventArgs e)
        {

            ReceptDtos recept = KreiranjeRecepta();

            receptKontroler.KreiranjeRecepta(recept) ;

            this.Close();
           

        }

         public ReceptDtos KreiranjeRecepta()
          {
             
              string jbmg = Pacijent.Text;
              string datump = Datum.Text;

              string lek = lekovi.Text;
              string kolicinaleka = (kolicina.Text);


            Dictionary<string, string> recnik = new Dictionary<string, string>();
            recnik[lek]=kolicinaleka;

            return new ReceptDtos("0", id2.Text, jbmg, datump, recnik);
            ;
          }
       }
    }


