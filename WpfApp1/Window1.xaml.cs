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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        static string Jelszo_titkositas(string jelszo)
        {
            char[] titkositott_jelszo = jelszo.ToCharArray(); 

            for (int i = 0; i < titkositott_jelszo.Length; i++) 
            {
                titkositott_jelszo[i] = (char)(titkositott_jelszo[i] + 20); 
            }
            string titkos_jelszo = new string(titkositott_jelszo); 
            return titkos_jelszo; 
        }
        private void bejelentkezes_Click(object sender, RoutedEventArgs e)
        {
            if (fnev.Text != "" & jelszo_be.Password != "")
            {
                string nev = fnev.Text;
                string jelszo = Jelszo_titkositas(jelszo_be.Password);

                if (File.Exists(nev + ".txt"))
                {
                    string file = File.ReadAllText(nev + ".txt");
                    string[] files = file.Split(' ');
                    if (jelszo == files[3])
                    {
                        MessageBox.Show("Sikeres bejelentkezés");
                        Window2 f = new Window2();
                        f.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("A jelszók nem egyeznek!");
                    }
                }
                else
                {
                    MessageBox.Show("Nem létezik ilyen felhasználónevű fiók!");
                }
            }
            else
            {
                MessageBox.Show("A mezők nem lehetnek üresek");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
