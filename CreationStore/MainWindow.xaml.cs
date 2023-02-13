using CreationStore.ApplicationData;
using CreationStore.Pages.AuthPage;
using CreationStore.Pages.CreatePage;
using CreationStore.Pages.MainPage;
using CreationStore.Pages.ProfilePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
using System.Windows.Threading;

namespace CreationStore
{

    public partial class MainWindow : Window
    {
        public int user_role;

        public int SEditMode;

        public string SproductID;
        public string SproductName;
        public string SproductDescription;
        public string SproductManufacturer;
        public decimal SproductCost;
        public int SproductQuantityInStock;

        public MainWindow()
        {
            InitializeComponent();

            // Подключаем модель БД
            AppConnect.modeldb = new TradeEntities();

            // Задаем начальную страницу
            AppFrame.frameMain = MainGridFrame;
            MainGridFrame.Navigate(new AuthPage());
        }

        // Переход на главную
        public void SwitchMain()
        {
            MainGridFrame.Navigate(new MainPage());
        }

        // Переход на вход
        public void SwitchAuth()
        {
            MainGridFrame.Navigate(new AuthPage());
        }

        // Переход на профиль
        public void SwitchProfile()
        {
            MainGridFrame.Navigate(new ProfilePage());
        }

        // Переход на создание
        public void SwitchCreate()
        {
            MainGridFrame.Navigate(new CreatePage());
        }

        // Вход в гостевой режим
        private void btnGuestClick_Click(object sender, RoutedEventArgs e)
        {
            // Ищем гостя в БД
            try
            {
                var userObject = AppConnect.modeldb.Client.FirstOrDefault(x => x.UserLogin == "Guest" && x.UserPassword == "Guest");

                btnGuestClick.Visibility = Visibility.Collapsed;
                btnGoToAuth.Visibility = Visibility.Visible;

                user_role = 4;
                SwitchMain();
            }
            catch
            {
                MessageBox.Show("Ошибка работы гостевого режима. Обратитесь в поддержку", "Техническая неисправность :(");
            }
        }

        // Переход из гостевого режима к Авторизации
        private void btnGoToAuth_Click(object sender, RoutedEventArgs e)
        {
            btnGuestClick.Visibility = Visibility.Visible;
            btnGoToAuth.Visibility = Visibility.Collapsed;

            SwitchAuth();
        }
    }
}
