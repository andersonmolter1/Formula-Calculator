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
    public sealed partial class Basic : Page
    {
        public Basic()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((text1.Text == "") || (text2.Text == ""))
            {
                return;
            }
            else
            {
                text4.Text = "+";
                try
                {
                    a = Double.Parse(text1.Text);
                    b = Double.Parse(text2.Text);
                    text3.Text = (a + b).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if ((text1.Text == "") || (text2.Text == ""))
            {
                return;
            }
            else
            {
                text4.Text = "-";
                try
                {
                    a = Double.Parse(text1.Text);
                    b = Double.Parse(text2.Text);
                    text3.Text = (a - b).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ((text1.Text == "") || (text2.Text == ""))
            {
                return;
            }
            else
            {
                text4.Text = "/";
                try
                {
                    a = Double.Parse(text1.Text);
                    b = Double.Parse(text2.Text);
                    text3.Text = (a / b).ToString();
                }catch
                {
                    return;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if ((text1.Text == "") || (text2.Text == ""))
            {
                return;
            }
            else
            {
                try
                {
                    text4.Text = "*";
                    a = Double.Parse(text1.Text);
                    b = Double.Parse(text2.Text);
                    text3.Text = (a * b).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
        }
    }
}
