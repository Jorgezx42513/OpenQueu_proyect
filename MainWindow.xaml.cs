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

namespace OpenQueu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        State_ports state_Ports = new State_ports();
        OpenPort OpenPort = new OpenPort(); 
        Act_MyIni Act_MyIni = new Act_MyIni();
        Button_state button_State;
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void controlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void ButtonMin_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Minimized;
        }

        private void Buton_port_MySQL_Click(object sender, RoutedEventArgs e)
        {
            state_Ports._MyMySQL_port  = OpenPort.openPort(@"mysql\bin\mysqld --defaults-file=mysql\bin\my.ini --standalone", "taskkill /IM \"mysqld.exe\" /F", state_Ports.MySQL_port);
             button_State = new Button_state(Buton_port_MySQL,state_Ports.MySQL_port);
        }

        private void Btn_reset_MySQL_Click(object sender, RoutedEventArgs e)
        {
            Act_MyIni = new Act_MyIni();
        }

        private void Buton_port_apache_Click(object sender, RoutedEventArgs e)
        {
            state_Ports._Apache_port = OpenPort.openPort(@"apache\bin\httpd.exe", "taskkill /IM \"httpd.exe\" /F", state_Ports.Apache_port);
            button_State = new Button_state(Btn_port_apache,state_Ports.Apache_port);

        }
        private void Btn_reset_apache_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_filezilla_Click(object sender, RoutedEventArgs e)
        {
            state_Ports._filezilla_port = OpenPort.openPort(@"FileZillaFTP\FileZillaServer.exe" , "\"FileZillaFTP\\FileZillaServer.exe\" /stop", state_Ports.Filezilla_port);
            button_State = new Button_state(Btn_port_filezilla,state_Ports.Filezilla_port);
        }

        private void Btn_reset_filezilla_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
