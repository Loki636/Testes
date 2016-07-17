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
    /// Логика взаимодействия для Discipline_CRUD_.xaml
    /// </summary>
    public partial class Discipline_CRUD_ : Window
    {
        public Discipline_CRUD_()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            Sttetings Settings = new Sttetings();
            this.Close();
            Settings.Show();
        }
    }
}
