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

namespace H3425_T1b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BLKirjain kirjaimet = new BLKirjain();
        public String jono;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            jono = textBox.Text;
            jono = jono.ToLower();
            kirjaimet.ClearList();
            foreach (char c in jono)
            {
                kirjaimet.AddCharacter(c);
            }
            UpdateDataSource();
            label.Content = "Yhteensä " + kirjaimet.totalChars + " merkkiä ja " + kirjaimet.differentChars + " eri kirjainta.";
        }

        private void UpdateDataSource()
        {
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = kirjaimet.GetKirjaimet();
        }
    }
}
