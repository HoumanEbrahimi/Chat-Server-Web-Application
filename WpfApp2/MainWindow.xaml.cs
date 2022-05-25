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
using System.Net.Sockets;
using System.Windows.Shapes;
using System.Net;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TcpClient client;
        public RelayCommand ConnectToServer { get; set; }
        private  serverHelper server;
        public string Username { get; set; }

        public string bab { get; set; }

        public  void Send(object sender, RoutedEventArgs ee)
        {
            Username = from.Text;
            

        }

        public MainWindow()
        {
            // InitializeComponent();

            server = new serverHelper();
            //Username = from.Text;



            ConnectToServer = new RelayCommand(o => server.ConnectToServerC(Username));



        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }

        private void Shutdown(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void Minimize(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;

        }

        private void Minmax(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Minimized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }

        }
        private void Connect(object sender, RoutedEventArgs ee)
        {



        }

        private void Select2(object sender, RoutedEventArgs ee)
        {




        }


        private void to_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}
