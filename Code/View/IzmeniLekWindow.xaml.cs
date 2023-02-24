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
    /// Interaction logic for IzmeniLekWindow.xaml
    /// </summary>
    public partial class IzmeniLekWindow : Window
    {

        private readonly LekKontroler lekKontroler;
        private readonly KorisnikKontroler korisnikKontroler;
        private readonly ReceptKontroler receptKontroler;
        public IzmeniLekWindow()
        {
            InitializeComponent();
        }

        

       

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void IzmeniLek(object sender, RoutedEventArgs e)

        {
            string sifraleka = sifra.Text;
            LekDtos lek = lekKontroler.IzmeniLek(sifraleka);
               
        }
            
        }
    }


