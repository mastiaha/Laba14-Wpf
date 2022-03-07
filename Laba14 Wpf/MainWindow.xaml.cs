using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba14_Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Инжир",
                ProdPrice = 170,
                ProdImage = "Data/Инжир.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Хурма",
                ProdPrice = 185,
                ProdImage = "Data/Хурма.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Фейхоа",
                ProdPrice = 250,
                ProdImage = "Data/Фейхоа.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Чайник",
                ProdPrice = 1500,
                ProdImage = "Data/Чайник.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Утюг",
                ProdPrice = 4500,
                ProdImage = "Data/Утюг.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            products.Add(new Product()
            {
                ProdName = "Кофемашина",
                ProdPrice = 17000,
                ProdImage = "Data/Кофемашина.jpg",
                ProductCategory = ProductCategorys.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
