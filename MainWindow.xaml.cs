using System.Collections.ObjectModel;
using System.Windows;

namespace Products
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Product> _productList;

        public MainWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            _productList = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Яблоки",
                    Price = 111.11,
                    Picture = "Data/Apple.png",
                    Category = ProductCategories.Food
                },
                new Product
                {
                    Name = "Блендер",
                    Price = 5000,
                    Picture = "Data/Blender.png",
                    Category = ProductCategories.Appliances
                },
                new Product
                {
                    Name = "Груши",
                    Price = 123.45,
                    Picture = "Data/Pear.png",
                    Category = ProductCategories.Food
                },
                new Product
                {
                    Name = "Лимоны",
                    Price = 200,
                    Picture = "Data/Lemon.png",
                    Category = ProductCategories.Food
                },
                new Product
                {
                    Name = "Миксер",
                    Price = 10000,
                    Picture = "Data/Mixer.png",
                    Category = ProductCategories.Appliances
                },
                new Product
                {
                    Name = "Помидоры",
                    Price = 300,
                    Picture = "Data/Tomato.png",
                    Category = ProductCategories.Food
                }
            };
            lstProduct.ItemsSource = _productList;
        }
    }
}