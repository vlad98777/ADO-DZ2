using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADO_DZ2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Задание 1
        //[DllImport("user32.dll", EntryPoint = "MessageBoxA", CharSet = CharSet.Ansi)]
        //private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);

        //public MainWindow()
        //{
        //    InitializeComponent();
        //}
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Отобразить сообщение с именем пользователя
        //    MessageBox(IntPtr.Zero, "Ваше имя: John Doe", "Информация", 0);

        //    // Отобразить сообщение с номером телефона
        //    MessageBox(IntPtr.Zero, "Ваш номер телефона: 123-456-7890", "Информация", 0);

        //}



        ////Задание 2
        //[DllImport("user32.dll", EntryPoint = "FindWindowA", CharSet = CharSet.Ansi)]
        //private static extern IntPtr FindWindow(string className, string windowName);

        //[DllImport("user32.dll", EntryPoint = "SendMessageA", CharSet = CharSet.Ansi)]
        //private static extern int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        //private const uint WM_SETTEXT = 0x000C;
        //private const uint WM_CLOSE = 0x0010;

        //public MainWindow()
        //{
        //    InitializeComponent();
        //}

        //private void FindWindow_Click(object sender, RoutedEventArgs e)
        //{
        //    // Найти окно текущего приложения
        //    IntPtr hWnd = FindWindow(null, Title);

        //    if (hWnd != IntPtr.Zero)
        //    {
        //        MessageBox.Show("Окно найдено.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Окно не найдено.");
        //    }
        //}

        //private void ChangeTitle_Click(object sender, RoutedEventArgs e)
        //{
        //    // Найти окно текущего приложения
        //    IntPtr hWnd = FindWindow(null, Title);

        //    if (hWnd != IntPtr.Zero)
        //    {
        //        // Изменить заголовок окна
        //        string newTitle = "Новое название окна";
        //        SendMessage(hWnd, WM_SETTEXT, IntPtr.Zero, newTitle);
        //    }
        //}

        //private void CloseWindow_Click(object sender, RoutedEventArgs e)
        //{
        //    // Найти окно текущего приложения
        //    IntPtr hWnd = FindWindow(null, Title);

        //    if (hWnd != IntPtr.Zero)
        //    {
        //        // Закрыть окно
        //        SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        //    }
        //}

        //    //Задание 3
        //    [DllImport("kernel32.dll", EntryPoint = "Beep")]
        //    private static extern bool Beep(uint dwFreq, uint dwDuration);

        //    [DllImport("user32.dll", EntryPoint = "MessageBeep")]
        //    private static extern bool MessageBeep(uint uType);

        //    public MainWindow()
        //    {
        //        InitializeComponent();
        //    }

        //    private void PlayBeep_Click(object sender, RoutedEventArgs e)
        //    {
        //        // Воспроизвести звуковой сигнал с частотой 1000 Гц в течение 1 секунды
        //        Beep(1000, 1000);
        //    }

        //    private void PlayMessageBeep_Click(object sender, RoutedEventArgs e)
        //    {
        //        // Воспроизвести звуковой сигнал типа "ошибка"
        //        MessageBeep(0);
        //    }

        //Задание 4
    //    [DllImport("user32.dll", EntryPoint = "SetWindowTheme")]
    //    private static extern bool SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //    }

    //    private void ChangeStyle_Click(object sender, RoutedEventArgs e)
    //    {
    //        // Получить дескриптор окна TextBox
    //        HwndSource source = PresentationSource.FromVisual(textBox) as HwndSource;
    //        IntPtr hWnd = source.Handle;

    //        // Изменить стиль TextBox на "Luna"
    //        SetWindowTheme(hWnd, "Luna", null);
    //    }
    }
}

