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
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            name.Focus();
        }
        static string Jelszo_titkositas(string jelszo) //metódus static = láthatóság(minden ugyannabba a fájlba) string = visszatérési érték, neve
        {
            char[] titkositott_jelszo = jelszo.ToCharArray(); //a jelszó character-é alakítja

            for (int i = 0; i < titkositott_jelszo.Length; i++) //körbejárja a titkositott_jelszo tömb
            {
                titkositott_jelszo[i] = (char)(titkositott_jelszo[i] + 20); // hozzá ad 20at a character kódhoz
            }
            string titkos_jelszo = new string(titkositott_jelszo); // vissza adja egy változóba
            return titkos_jelszo; //visszatér vele
        }
        private void send_Click(object sender, RoutedEventArgs e)
        {
            //változók deklarálása
            string nev = name.Text;
            string email = email_in.Text;
            string kor = date.Text;
            string jelszo1 = pass1.Password;
            string jelszo2 = pass2.Password;
            //változók deklarálása

            if (nev != "" & email != "" & kor != "" & jelszo1 != "" & jelszo2 != "")//ne legyen üresen hagyott mező
            {
                int kor2 = 0;
                if (int.TryParse(kor, out kor2))//szám-e a kor
                {
                    if (email.Contains("@") & email.Contains("."))//az email tartalmaz-e @ és .
                    {
                        if (jelszo1 == jelszo2) //megegyezik a két jelszó
                        {
                            MessageBox.Show("A fiók sikeresen létrehozva!");
                            File.WriteAllText(nev + ".txt", nev + " " + email + " " + kor2 + " " + Jelszo_titkositas(jelszo1));
                            Window2 window = new Window2();
                            window.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("A két jelszónak egyeznie kell!");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Az emailnek kell tartalmaznia @ és . karaktert!");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("A kor mezőbe számnak kell lennie!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Nem lehet üresen hagyott mező!");
                return;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void man_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void woman_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window = new Window1();
            window.Show();
            Close();
        }
    }
}
