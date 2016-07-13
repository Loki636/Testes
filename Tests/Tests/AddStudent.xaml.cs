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
    /// Логика взаимодействия для AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {

        public AddStudent()
        {
            InitializeComponent();
        }
        public AddStudent(String NameStudent,String NameGroup)
        {
            GroupBox.SelectedItem = NameGroup;
            Student.Text = NameStudent;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Students_CRUD_ Students = new Students_CRUD_();
            Students.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Students_CRUD_ Students = new Students_CRUD_();
            Students.Show();
            this.Close();
        }
    }
}
