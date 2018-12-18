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

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для Mini.xaml
    /// </summary>
    public partial class Mini : Window
    {
        public Mini()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            delete delete = new delete();
            delete.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Addit addit = new Addit();
            addit.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tabl tabl = new tabl();
            tabl.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sersh sersh = new Sersh();
            sersh.Show();
        }
    }
}
