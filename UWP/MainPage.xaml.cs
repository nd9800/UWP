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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
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
        int count = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            string emailTo = input1.Text;
            string title = input2.Text;
            string content = input3.Text;
            TxtBlock.Text += "Email number: "+count+"\n"
                +"Email to: "+emailTo +"\n"
                + "Title: " + title + "\n" 
                + "Content: " + content + "\n" ;
        }
    }
}
