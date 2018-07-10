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
    public sealed partial class Pytha : Page
    {
        public Pytha()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double c = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((text1.Text == "") || (text2.Text == ""))
            {
                return;
            }
            else
            {
                try
                {
                    a = Double.Parse(text1.Text);
                    b = Double.Parse(text2.Text);
                    text3.Text = Math.Sqrt((a * a) + (b * b)).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if ((text8.Text == "") || (text9.Text == ""))
            {
                return;
            }
            else
            {
                try
                {
                    b = Double.Parse(text8.Text);
                    c = Double.Parse(text9.Text);
                    text7.Text = Math.Sqrt((c * c) - (b * b)).ToString();
                }
                catch
                {
                    return;
                }
            }

           
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if ((text4.Text == "") || (text6.Text == ""))
            {
                return;
            }
            else
            {
                try
                {
                    a = Double.Parse(text4.Text);
                    c = Double.Parse(text6.Text);
                    text5.Text = Math.Sqrt((c * c) - (a * a)).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
            text7.Text = "";
            text8.Text = "";
            text9.Text = "";
        }
    }
}
