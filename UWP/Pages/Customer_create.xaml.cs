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
using UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Customer_create : Page
    {
        private static List<CustomerList> c = new List<CustomerList>();
        public Customer_create()
        {
            this.InitializeComponent();
        }

        internal static List<CustomerList> C { get => c; set => c = value; }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            
            string name = input1.Text;
            int age = Convert.ToInt32(input2.Text);
            CustomerList cl = new CustomerList(name, age);
            C.Add(cl);
            SubFrame2.Navigate(typeof(Pages.Customer));
        }
    }
}
