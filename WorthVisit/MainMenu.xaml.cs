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

namespace WorthVisit
{
    /// <summary>
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }
  

    private void ClcAmerykaN(object sender, RoutedEventArgs e)
        {
            wyswietlokno("AmerykaN");

        }

        private void ClcEuropa(object sender, RoutedEventArgs e)
        {
            wyswietlokno("Europa");

        }

        private void ClcAzja(object sender, RoutedEventArgs e)
        {
            wyswietlokno("AZja");
        }

        private void ClcAmerykaS(object sender, RoutedEventArgs e)
        {
            wyswietlokno("AmerykaS");
        }

        private void ClcAfryka(object sender, RoutedEventArgs e)
        {
            wyswietlokno("Afryka");


        }

        private void ClcAustralia(object sender, RoutedEventArgs e)
        {
            wyswietlokno("Australia");
            
        }
        public void wyswietlokno(string kontynent)
        {
            string cos = kontynent;
            miejsca miejsce = new miejsca(cos);
            miejsce.Show();
            this.Close();
        }

    }
}
