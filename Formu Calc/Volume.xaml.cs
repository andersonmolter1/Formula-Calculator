using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Formu_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Volume : Page
    {
        public Volume()
        {
            this.InitializeComponent();
        }
        double a = 0;
        double b = 0;
        double c = 0;
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (text4.Text == "")
            {
                return;
            }
            else
            {
                a = Double.Parse(text55.Text);
                b = Double.Parse(text4.Text);
                c = Double.Parse(text2.Text);
                text1.Text = (a * b * c).ToString();
            }
        }

    private void Button_Click3(object sender, RoutedEventArgs e)
        { 
            if (text11.Text == "" || text22.Text == "" || text33.Text == "")
            {
                return;
            }
            else
            {
                a = Double.Parse(text11.Text);
                b = Double.Parse(text22.Text);
                c = Double.Parse(text33.Text);
                text44.Text = ((a * b) * (c / 3)).ToString();

            }
        }
    



    private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (text5.Text == "")
            {
                return;
            }
            else
            {

                try
                {
                    a = Double.Parse(text5.Text);
                    text7.Text = ((4 / 3) * Math.PI * (a * a)).ToString();
                }
                catch
                {
                    return;
                }
            }

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text4.Text = "";
            text11.Text = "";
            text5.Text = "";
            text7.Text = "";
            text22.Text = "";
            text55.Text = "";
            text33.Text = "";
            text44.Text = "";

        }
    }
}
