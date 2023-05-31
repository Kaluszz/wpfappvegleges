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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public int ossz_db;
        public int ossz_ar;
        public List<string> termekek_list = new List<string>();
        public Window2()
        {
            InitializeComponent();
            gyümölcsök.Visibility = Visibility.Visible;
            zöldségek.Visibility = Visibility.Hidden;
            kosar.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gyümölcsök.Visibility = Visibility.Visible;
            zöldségek.Visibility = Visibility.Hidden;
            kosar.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            gyümölcsök.Visibility = Visibility.Hidden;
            zöldségek.Visibility = Visibility.Visible;
            kosar.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            gyümölcsök.Visibility = Visibility.Hidden;
            zöldségek.Visibility = Visibility.Hidden;
            kosar.Visibility = Visibility.Visible;
        }

        private void korte_Click_1(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 300;
            termekek_list.Add("Körte");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Körte");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Süti" + (etel2 - 1) + "db " + ((300 * etel2) - 300) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Süti" + etel2 + "db " + (300 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 350;
            termekek_list.Add("Dinnye");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Dinnye");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Dinnye" + (etel2 - 1) + "db " + ((350 * etel2) - 350) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Dinnye" + etel2 + "db " + (350 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 400;
            termekek_list.Add("Citrom");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Citrom");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Citrom" + (etel2 - 1) + "db " + ((400 * etel2) - 400) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Citrom" + etel2 + "db " + (400 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 400;
            termekek_list.Add("Alma");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Alma");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Alma" + (etel2 - 1) + "db " + ((400 * etel2) - 400) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Alma" + etel2 + "db " + (400 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 500;
            termekek_list.Add("Eper");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Eper");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Eper" + (etel2 - 1) + "db " + ((500 * etel2) - 500) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Eper" + etel2 + "db " + (500 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 450;
            termekek_list.Add("Narancs");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Narancs");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Narancs" + (etel2 - 1) + "db " + ((450 * etel2) - 450) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Narancs" + etel2 + "db " + (450 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 400;
            termekek_list.Add("Paradicsom");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Paradicsom");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Paradicsom" + (etel2 - 1) + "db " + ((400 * etel2) - 400) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Paradicsom" + etel2 + "db " + (400 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 450;
            termekek_list.Add("Saláta");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Saláta");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Saláta" + (etel2 - 1) + "db " + ((450 * etel2) - 450) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Saláta" + etel2 + "db " + (450 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 400;
            termekek_list.Add("Brokkoli");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Brokkoli");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Brokkoli" + (etel2 - 1) + "db " + ((400 * etel2) - 400) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Brokkoli" + etel2 + "db " + (400 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 350;
            termekek_list.Add("Paprika");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Paprika");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Paprika" + (etel2 - 1) + "db " + ((350 * etel2) - 350) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Paprika" + etel2 + "db " + (350 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 400;
            termekek_list.Add("Padlizsán");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Padlizsán");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Padlizsán" + (etel2 - 1) + "db " + ((400 * etel2) - 400) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Padlizsán" + etel2 + "db " + (400 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ossz_db++;
            ossz_ar += 350;
            termekek_list.Add("Répa");
            int etel2 = 0;
            etel2 = termekek_list.Count(x => x == "Répa");
            if (etel2 > 0)
            {
                if (etel2 > 1)
                {
                    kosar_tartalma.Items.Remove("Répa" + (etel2 - 1) + "db " + ((350 * etel2) - 350) + "Ft" + "\t");
                }
                kosar_tartalma.Items.Add("Répa" + etel2 + "db " + (350 * etel2) + "Ft" + "\t");
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            gyümölcsök.Visibility = Visibility.Hidden;
            zöldségek.Visibility = Visibility.Hidden;
            kosar.Visibility = Visibility.Visible;
            ossz_ki.Content = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            termekek_list.Clear();
            kosar_tartalma.Items.Clear();
            ossz_ar = 0;
            ossz_db = 0;
            ossz_ki.Content = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

            MessageBox.Show("A rendelés leadva!");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            termekek_list.Clear();
            kosar_tartalma.Items.Clear();
            ossz_ar = 0;
            ossz_db = 0;
            ossz_ki.Content = "Összegzés: " + ossz_db + "db " + ossz_ar + "Ft";

            MessageBox.Show("A termékek törölve lettek!");

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
