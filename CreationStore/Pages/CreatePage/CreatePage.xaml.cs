using CreationStore.ApplicationData;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace CreationStore.Pages.CreatePage
{
    /// <summary>
    /// Логика взаимодействия для CreatePage.xaml
    /// </summary>

    public partial class CreatePage : Page
    {
        public byte[] file;

        public CreatePage()
        {
            InitializeComponent();

            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            if(mainWindow.SEditMode == 1)
            {
                Name.Text = mainWindow.SproductName;
                Description.Text = mainWindow.SproductDescription;
                Manufacturer.Text = mainWindow.SproductManufacturer;
                Cost.Text = mainWindow.SproductCost.ToString();
                Quantity.Text = mainWindow.SproductQuantityInStock.ToString();
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            if (mainWindow.SEditMode == 1)
            {
                Product product = AppConnect.modeldb.Product.Local.Where(x => x.ProductArticleNumber == mainWindow.SproductID).ToList()[0];
                product.ProductName = Name.Text;
                product.ProductDescription = Description.Text;
                product.ProductManufacturer = Manufacturer.Text;
                product.ProductCost = decimal.Parse(Cost.Text);
                product.ProductQuantityInStock = int.Parse(Quantity.Text);

                mainWindow.SEditMode = 0;
                mainWindow.SproductID = "";
                mainWindow.SproductName = "";
                mainWindow.SproductDescription = "";
                mainWindow.SproductManufacturer = "";
                mainWindow.SproductCost = 0;
                mainWindow.SproductQuantityInStock = 0;

                AppConnect.modeldb.SaveChanges();
                mainWindow.SwitchMain();
            } 
            else
            {
                Product product = AppConnect.modeldb.Product.Local.ToList()[5];
                product.ProductName = Name.Text;
                product.ProductDescription = Description.Text;
                product.ProductManufacturer = Manufacturer.Text;
                product.ProductCost = decimal.Parse(Cost.Text);
                product.ProductQuantityInStock = int.Parse(Quantity.Text);

                AppConnect.modeldb.SaveChanges();
                mainWindow.SwitchMain();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем элементы с главной страницы
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

            if (mainWindow.SEditMode == 1)
            {
                mainWindow.SEditMode = 0;
                mainWindow.SproductID = "";
                mainWindow.SproductName = "";
                mainWindow.SproductDescription = "";
                mainWindow.SproductManufacturer = "";
                mainWindow.SproductCost = 0;
                mainWindow.SproductQuantityInStock = 0;
            }

            mainWindow.SwitchMain();
        }
    }
}
