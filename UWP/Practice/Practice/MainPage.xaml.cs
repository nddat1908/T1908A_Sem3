﻿using Practice.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Practice
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;
        private ObservableCollection<Product> Products;

        public MainPage()
        {

            this.InitializeComponent();

            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/practice1.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/practice2.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/practice3.jpg" });
            Icons.Add(new Icon { IconPath = "Assets/practice4.jpg" });

            Products = new ObservableCollection<Product>();

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((Icon)ImageComboBox.SelectedValue).IconPath;
            Products.Add(new Product { Name = ProductNameTextBox.Text, Description = DescriptionTextBox.Text, Image = avatar });

            ProductNameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            ImageComboBox.SelectedIndex = -1;

            ProductNameTextBox.Focus(FocusState.Programmatic);
        }
    }
}