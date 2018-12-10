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
    /// Логика взаимодействия для avtiraz.xaml
    /// </summary>
    public partial class avtiraz : Window
    {
        public avtiraz()
        {
            InitializeComponent();
          
        }
        
        
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Mini mini = new Mini();
            mini.Show();
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Show();
            
            this.Close();
        }

        public void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }
    }
}
