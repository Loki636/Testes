using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            testBD();
        }

        public void testBD()
        {
           
        }

        private void SignInASStudent_Click(object sender, RoutedEventArgs e)
        {
            LogInAsStudent logInStudent = new LogInAsStudent();
            this.Hide();
            logInStudent.Show();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Sttetings Settings = new Sttetings();
            this.Close();
            Settings.Show();
        }
    }
}
