using CreationStore.ApplicationData;
using CreationStore.Pages.AuthPage;
using CreationStore.Pages.MainPage;
using System;
using System.Collections.Generic;
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
using System.Windows.Threading;

namespace CreationStore.Pages.AuthPage
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        // Создаем переменную для КАПТЧИ
        private string captcha;

        // Создаем счетчик нажатия на кнопку "Войти"
        private int clickCounter = 0;

        // Создаем таймер и время
        private DispatcherTimer timer;
        private int countdown = 11;

        public AuthPage()
        {
            InitializeComponent();

            GenerateCaptcha();

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
        }

        // Проверяем счетчик кнопки
        private void Check_ClickCounter()
        {
            if (clickCounter >= 1)
            {
                gridCaptcha.Visibility = Visibility.Visible;
            }

            if (clickCounter >= 2)
            {
                btnAuth.IsEnabled = false;
                timer.Start();
                countdown = 11;
            }
        }

        // Генерируем каптчу
        private void GenerateCaptcha()
        {
            Random random = new Random();
            int num1 = random.Next(100, 999);
            int num2 = random.Next(10, 99);
            captcha = (num1 + num2).ToString();
            labelCaptcha.Content = $"{num1} + {num2} = ?";
        }


        // Запускаем таймер
        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            labelError.Content = "Повторите попытку через " + countdown + " секунд";

            if (countdown == 0)
            {
                timer.Stop();
                btnAuth.IsEnabled = true;
                labelError.Content = "";
            }
        }

        // Проводим авторизацию
        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            // Проверяем заполненность полей
            if (string.IsNullOrEmpty(userName.Text))
            {
                labelError.Content = "Пожалуйста введите логин.";
                userName.Focus();

                clickCounter++;
                Check_ClickCounter();

                return;
            }

            if (string.IsNullOrEmpty(userPass.Password))
            {
                labelError.Content = "Пожалуйста введите пароль.";
                userPass.Focus();

                clickCounter++;
                Check_ClickCounter();

                return;
            }

            // Проверяем каптчу
            if (gridCaptcha.Visibility == Visibility.Visible)
            {
                if (string.IsNullOrEmpty(userCaptcha.Text))
                {
                    labelError.Content = "Пожалуйста введите CAPTCHA.";
                    userCaptcha.Focus();

                    clickCounter++;
                    Check_ClickCounter();

                    return;

                }
                else if (userCaptcha.Text != captcha)
                {
                    GenerateCaptcha();
                    labelError.Content = "CAPTCHA введена не верно.";
                    userCaptcha.Focus();

                    clickCounter++;
                    Check_ClickCounter();

                    return;
                }
                else
                {
                    clickCounter = 0;
                }
            }

            clickCounter = 0;

            // Ищем пользователя в БД
            try
            {
                var userObject = AppConnect.modeldb.Client.FirstOrDefault(x => x.UserLogin == userName.Text && x.UserPassword == userPass.Password);

                if (userObject == null)
                {
                    labelError.Content = "Пользователя с такими данными не существует.";
                }
                else
                {
                    // Получаем элементы с главной страницы
                    MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

                    Button btnGuestClick = (Button)mainWindow.FindName("btnGuestClick");
                    Grid gridProfileButton = (Grid)mainWindow.FindName("gridProfileButton");
                    Button btnGoToProfile = (Button)mainWindow.FindName("btnGoToProfile");

                    btnGuestClick.Visibility = Visibility.Collapsed;
                    gridProfileButton.Visibility = Visibility.Visible;
                    btnGoToProfile.Content = userObject.UserName;

                    // Проверяем роль пользователя
                    switch (userObject.UserRole)
                    {
                        case 2:
                            mainWindow.user_role = 2;
                            btnGoToProfile.Content = "Менеджер " + userObject.UserName;
                            break;
                        case 3:
                            mainWindow.user_role = 3;
                            btnGoToProfile.Content = "Администратор " + userObject.UserName;
                            break;
                        default:
                            labelError.Content = "Статус доступа не обнаружен. Вы будете авторизованы как гость.";
                            break;
                    }
                    mainWindow.SwitchMain();
                }

            }
            catch
            {
                labelError.Content = "Ошибка работы сервера. Обратитесь в поддержку";
            }
        }
    }
}
