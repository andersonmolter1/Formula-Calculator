using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Formu_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Basic));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Pytha));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Volume));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Area));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(distance));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(calc));
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Finance));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
         
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(quad));
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }
    }
}
