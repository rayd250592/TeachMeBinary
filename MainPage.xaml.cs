using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TeachMeBinary
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }



        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            

            

            int onetwoeight = Convert.ToInt32( _128.Text);
            int sixtyfour = Convert.ToInt32(_64.Text);
            int thirtytwo = Convert.ToInt32(_32.Text);
            int sixteen = Convert.ToInt32(_16.Text);
            int eight = Convert.ToInt32(_8.Text);
            int two = Convert.ToInt32(_2.Text);
            int one = Convert.ToInt32(_1.Text);





            if (onetwoeight != 0 && onetwoeight != 1 )
 
            {

                var messageDialog1 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog1.ShowAsync();
                onetwoeight = 0;
                _128.Text = "0";
                


            }

            else
            {

                onetwoeight = onetwoeight;


            }

            if (sixtyfour != 0 && sixtyfour != 1)
            {

                var messageDialog2 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog2.ShowAsync();
                sixtyfour = 0;
                _64.Text = "0";



            }

            else
            {

                sixtyfour = sixtyfour;


            }

            if (thirtytwo != 0 && thirtytwo != 1)
            {

                var messageDialog3 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog3.ShowAsync();
                thirtytwo = 0;
                _32.Text = "0";



            }

            else
            {

                thirtytwo = thirtytwo;


            }

            if (sixteen != 0 && sixteen != 1)
            {

                var messageDialog4 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog4.ShowAsync();
                sixteen = 0;
                _16.Text = "0";



            }

            else
            {

                sixteen = sixteen;


            }

            if (eight != 0 && eight != 1)
            {

                var messageDialog5 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog5.ShowAsync();
                eight = 0;
                _8.Text = "0";



            }

            else
            {

                eight = eight;


            }

            if (two != 0 && two != 1)
            {

                var messageDialog6 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog6.ShowAsync();
                two = 0;
                _2.Text = "0";



            }

            else
            {

                two = two;


            }

            if (one != 0 && one != 1)
            {

                var messageDialog7 = new MessageDialog("Please enter a 0 or a 1");
                await messageDialog7.ShowAsync();
                one = 0;
                _1.Text = "0";



            }

            else
            {

                one = one;


            }

            

            
          
           int result = (128 * onetwoeight) + (64 * sixtyfour) + (32 * thirtytwo) + (16 * sixteen) + (8 * eight) + (2 * two) + (1 * one);
           calc.Text = result.ToString();
        }

        
    }
}
