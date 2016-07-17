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
    /// Логика взаимодействия для Sttetings.xaml
    /// </summary>
    public partial class Sttetings : Window
    {
        public Sttetings()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            this.Close();
            MainWindow.Show();
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            Students_CRUD_ _studetns = new Students_CRUD_();
            this.Close();
            _studetns.Show();
        }

        private void Disciplines_Click(object sender, RoutedEventArgs e)
        {
            Discipline_CRUD_ Discipline = new Discipline_CRUD_();
            this.Close();
            Discipline.Show();
        }
    }
}
