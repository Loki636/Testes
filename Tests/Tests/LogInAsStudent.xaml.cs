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
using System.Windows.Shapes;

namespace Tests
{
    /// <summary>
    /// Логика взаимодействия для LogInAsStudent.xaml
    /// </summary>
    public partial class LogInAsStudent : Window
    {
        public LogInAsStudent()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            ContinueQuest ConQuest = new ContinueQuest("1231","12431");
            this.Close();
            ConQuest.Show();
        }
    }
}
