using cashierproject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cashierproject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RefreshProductList();
        }

        private void AddProduct_Clicked(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(priceEntry.Text);
            int quantity = int.Parse(quantityEntry.Text);

            var product = new Product
            {
                Name = productNameEntry.Text,
                Price = price,
                Quantity = quantity
            };

            App.DatabaseHelper.InsertProduct(product);

            RefreshProductList();
        }

        private void RefreshProductList()
        {
            var products = App.DatabaseHelper.GetProducts();
             productListView.ItemsSource = products;
        }
    }
}
