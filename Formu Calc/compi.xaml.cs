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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Formu_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class compi : Page
    {
        public compi()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        double h = 0;
        double r = 0;
        double g = 0;
        double f = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Double.Parse(text1.Text);
                c = Double.Parse(text3.Text);
                d = Double.Parse(text4.Text);
                h = Double.Parse(text6.Text);
                f = c * h;
                r = Math.Pow((1 + ((d/100) / h)), f);
                g = a * r;
                text7.Text = (g).ToString();
            }
            catch
            {
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text6.Text = "";
            text7.Text = "";
        }
    }
}


