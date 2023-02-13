using CreationStore.ApplicationData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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

namespace CreationStore.Pages.MainPage
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            var manufacturers = (from product in AppConnect.modeldb.Product.ToList() select product.ProductManufacturer).Distinct().ToList();
            manufacturers.Add("Все производители");

            Filtration.ItemsSource = manufacturers;

            var currentProduct = AppConnect.modeldb.Product.ToList();

            ProductList.ItemsSource = currentProduct;

            SortingBox.SelectedIndex = 1;
            Filtration.SelectedItem = "Все производители";

            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (mainWindow.user_role == 3)
            {
                gridTools.Visibility = Visibility.Visible;
            }

        }

        // При загрузке страницы
        private void productsGrid_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateProducts();
        }

        // Метод обновления товаров
        public void UpdateProducts()
        {
            // Вызов фильтрации
            productFilter();
            // Вызов поиска
            produstSearch();
            // Вызов сортировки
            productSort();
        }



        // Метод фильтрации
        public void productFilter()
        {
            var currentProducts = AppConnect.modeldb.Product.ToList();
            var Filter = (string)Filtration.SelectedItem;

            if (Filter == "Все производители") ProductList.ItemsSource = currentProducts;
            else currentProducts = (from product in currentProducts where product.ProductManufacturer == Filter select product).ToList();
        }

        // Метод поиска
        public void produstSearch()
        {
            var currentProducts = AppConnect.modeldb.Product.ToList();
            var Filter = (string)Filtration.SelectedItem;

            if (Filter == "Все производители") ProductList.ItemsSource = currentProducts;
            else currentProducts = (from product in currentProducts where product.ProductManufacturer == Filter select product).ToList();

            currentProducts = currentProducts.Where(p => p.ProductName.ToLower().Contains(SearchField.Text.ToLower())
            || p.ProductDescription.ToLower().Contains(SearchField.Text.ToLower())
            || p.ProductArticleNumber.ToLower().Contains(SearchField.Text.ToLower())
            || p.ProductManufacturer.ToLower().Contains(SearchField.Text.ToLower())).ToList();

            ProductList.ItemsSource = currentProducts;
        }

        // Метод сортировки
        public void productSort()
        {
            ComboBoxItem sort = (ComboBoxItem)SortingBox.SelectedItem;
            int sorting = int.Parse(sort.Tag.ToString());

            if (sorting == 1)
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ProductList.ItemsSource);
                view.SortDescriptions.Remove(new SortDescription("ProductCost", ListSortDirection.Ascending));
                view.SortDescriptions.Add(new SortDescription("ProductCost", ListSortDirection.Descending));
                ProductList.ItemsSource = view;
            }
            else
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ProductList.ItemsSource);
                view.SortDescriptions.Remove(new SortDescription("ProductCost", ListSortDirection.Descending));
                view.SortDescriptions.Add(new SortDescription("ProductCost", ListSortDirection.Ascending));
                ProductList.ItemsSource = view;
            }
            int AviableProducts = AppConnect.modeldb.Product.Count();
            int VisibleProducts = ProductList.Items.Count;

            CountProducts.Text = VisibleProducts + "/" + AviableProducts;
        }



        // При взаимодействии с полем поиска
        private void SearchField_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateProducts();
        }

        // При взаимодействии с полем сортировки
        private void SortingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateProducts();
        }

        // При взаимодействии с полем фильтрации
        private void Filtration_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            UpdateProducts();
        }


        // Добавление товара
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            mainWindow.SwitchCreate();
        }

        // Удаление товара
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var item = ProductList.SelectedItem as Product;

            AppConnect.modeldb.Product.Load();
            AppConnect.modeldb.Product.Local.Remove(item);
            AppConnect.modeldb.SaveChanges();
            UpdateProducts();
        }

        // Редактирование товара
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            try
            {
                Product product = (Product)ProductList.SelectedValue;

                mainWindow.SEditMode = 1;

                mainWindow.SproductID = product.ProductArticleNumber;
                mainWindow.SproductName = product.ProductName;
                mainWindow.SproductDescription = product.ProductDescription;
                mainWindow.SproductManufacturer = product.ProductManufacturer;
                mainWindow.SproductCost = product.ProductCost;
                mainWindow.SproductQuantityInStock = product.ProductQuantityInStock;
            }
            catch
            {
                MessageBox.Show("Ошибка редактирования товара.", "Техническая неисправность");
            }

            mainWindow.SwitchCreate();
        }
    }
}
