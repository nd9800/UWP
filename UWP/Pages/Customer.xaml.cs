﻿using System;
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

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Customer : Page
    {
        public Customer()
        {
            this.InitializeComponent();
        }

 

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubFrame.Navigate(typeof(Customer_create));
        }

        private void ListCustomer_Loaded(object sender, RoutedEventArgs e)
        {
         foreach(object value in Customer_create.C)
            {
                ListCustomer.Items.Add(value);
            }

        }
    }
}
