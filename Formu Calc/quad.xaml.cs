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
    public sealed partial class quad : Page
    {
        public quad()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double c = 0;
        double t = 0;
        double f = 0;
        double l = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Double.Parse(text1.Text);
                b = Double.Parse(text2.Text);
                c = Double.Parse(text3.Text);
                t = (b * b) - (4 * a * c);
                f = ((-1 * b) + Math.Sqrt(t)) / (2 * a);
                l = ((-1 * b) - Math.Sqrt(t)) / (2 * a);

                text4.Text = (f).ToString();
                text5.Text = (l).ToString();
                text11.Text = "";
                text111.Text = "";
                text1111.Text = "";
                text11111.Text = "";

                text22.Text = "";
                text222.Text = "";
                text2222.Text = "";
                text22222.Text = "";

                text33.Text = "";
                text333.Text = "";


                text11.Text = b.ToString();
                text111.Text = b.ToString();
                text1111.Text = b.ToString();
                text11111.Text = b.ToString();

                text22.Text = a.ToString();
                text222.Text = a.ToString();
                text2222.Text = a.ToString();
                text22222.Text = a.ToString();

                text33.Text = c.ToString();
                text333.Text = c.ToString();
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
            text11.Text = "b";
            text111.Text = "b";
            text1111.Text = "b";
            text11111.Text = "b";

            text22.Text = "a";
            text222.Text = "a";
            text2222.Text = "a";
            text22222.Text = "a";

            text33.Text = "c";
            text333.Text = "c";
            
        }
    }
}
