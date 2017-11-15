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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private List<Auto> autot;
        private const string polku = @"D:\K2177\TTOS0200\\";
        public MainWindow()
        {
            //Tänne koodi joka suoritetaan ikkunan avauksen luonnissa
            InitializeComponent();
            autot = BLAutotalli.HaeAutot();
            NaytaKuva("autotalli.png");
            //Asetetaan comboboxiin kaikki eri automerkit
            //Tapa 1
            List<string> merkit = new List<string>();
            merkit.Add("Audi");
            merkit.Add("Saab");
            merkit.Add("Volvo");
            cmbAutot.ItemsSource = merkit;
            //Tapa 2
            var result = autot.Select(n => n.Merkki.Distinct());
            cmbAutot.ItemsSource = result;
        }
        private void btnHaeAutot_Click(object sender, RoutedEventArgs e)
        {
            dgAutot.ItemsSource = autot;
        }
        private void NaytaKuva(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = "puuttuu.png";
            }
            //Kuvatiedostojen vakiopolku
            url = polku + url;
            //Kuvan näyttö
            BitmapImage pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(url);
            pic.EndInit();
            imgAuto.Stretch = Stretch.Fill;
            imgAuto.Source = pic;
        }
        private void dgAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object obj = dgAutot.SelectedItem;
            if (obj != null)
            {
                Auto valittu = (Auto)obj;
                NaytaKuva(valittu.URL);
            }
        }
        private void btnHaeAudit_Click(object sender, RoutedEventArgs e)
        {
            var result = autot.Where(n => n.Merkki.Contains("Audi"));
            dgAutot.ItemsSource = result;
        }
        private void cmbAutot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Suodatetaan datagridiin näkyviin vain valittu automerkki
            string merkki = cmbAutot.SelectedValue.ToString();
            var result = autot.Where(n => n.Merkki.Contains(merkki));
            dgAutot.ItemsSource = result;
        }
    }
}
