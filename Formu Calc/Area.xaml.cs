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
    public sealed partial class Area : Page
    {
        public Area()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (text8.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    a = Double.Parse(text7.Text);
                    b = Double.Parse(text8.Text);
                    text9.Text = (a * b).ToString();
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            text5.Text = "";
            text6.Text = "";
            text7.Text = "";
            text8.Text = "";
            text9.Text = "";
        }

       


        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (text4.Text == "" || text5.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    a = Double.Parse(text2.Text);
                    text3.Text = (Math.PI * (a * a)).ToString();
                }
                catch
                {
                    return;
                }
            }
        }

        private void button_click2(object sender, RoutedEventArgs e)
        {
            if (text4.Text == "" || text5.Text == "")
            {
                return;
            }
            else
            {
                try
                {
                    a = Double.Parse(text4.Text);
                    b = Double.Parse(text5.Text);
                    text6.Text = ((a * b) * .5).ToString();
                }
                catch
                {
                    return;
                }
            }
        }
    }
}
