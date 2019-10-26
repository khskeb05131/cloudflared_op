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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //btn_enable
        private void Btn_Enable(object sender, RoutedEventArgs e)
        {
            la_status.Foreground = App.Current.Resources["hex_enable"] as SolidColorBrush;
        }

        //btn_disable
        private void Btn_Disable(object sender, RoutedEventArgs e)
        {
            la_status.Foreground = App.Current.Resources["hex_disable"] as SolidColorBrush;
        }

        //btn_exit
        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Cmd(object sender, RoutedEventArgs e)
        {
            la_status.Foreground = App.Current.Resources["hex_cmd"] as SolidColorBrush;
        }

        private void Btn_Powered(object sender, RoutedEventArgs e)
        {
            la_status.Foreground = App.Current.Resources["hex_cmd"] as SolidColorBrush;
        }

        //btn_cmd
        //private void Btn_Cmd(object sender, RoutedEventArgs e)
        //{}
    }
}
