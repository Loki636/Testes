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
    /// Логика взаимодействия для Students_CRUD_.xaml
    /// </summary>
    public partial class Students_CRUD_ : Window
    {
        public Students_CRUD_()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Sttetings Settings = new Sttetings();
            this.Close();
            Settings.Show();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddStudent student = new AddStudent();
            this.Close();
            student.Show();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            AddStudent student = new AddStudent(StudentGroup.SelectedItem.ToString(),GroupBox.SelectedItem.ToString());
            this.Close();
            student.Show();
        }
    }
}
