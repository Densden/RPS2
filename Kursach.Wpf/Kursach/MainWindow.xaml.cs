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
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using ConsoleTelnet;

namespace Kursach
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public TestConnect Test { get; set; }
        public MainWindow()
        {
            var login = "sergey";
            var password = "Mirage";
            var comand = "";
            Test = new TestConnect(login,password,comand);
            this.DataContext = Test;
            InitializeComponent();
        }

        private void test1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test.SendCmd(command.Text);
           ResultText.Text = Test.GetAnswer().Replace("\0", "");
        }

       
    }
}
        

   
