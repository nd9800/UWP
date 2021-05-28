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
    public sealed partial class Layout : Page
    {
        public Layout()
        {
            this.InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            List<MenuItem> items = new List<MenuItem>();
            Menu.Items.Add(new MenuItem { Name = "Home", MenuPage="home" });
   
            Menu.Items.Add(new MenuItem { Name = "Customer", MenuPage = "customer" });
            Menu.Items.Add(new MenuItem { Name = "Contact", MenuPage = "contact" });

        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
           
            MenuItem item = Menu.SelectedItem as MenuItem;// object vua nhan
            switch(item.MenuPage)
            {
                case "home":
                    MainFrame.Navigate(typeof(Pages.Home),"Hi");
                    break;
            
                case "customer":
                    MainFrame.Navigate(typeof(Pages.Customer));
                    break;
                case "contact":
                    MainFrame.Navigate(typeof(Pages.Contact));
                    break;
            }
           
        }
    }
}
