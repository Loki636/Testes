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
    /// Логика взаимодействия для ContinueQuest.xaml
    /// </summary>
    public partial class ContinueQuest : Window
    {
        String NameStudent;
        String NameGroupStudent;

        public void SetNameStudent(String nameStudent)
        {
            NameStudent = nameStudent;
        }
        public String GetNameStudent() { return NameStudent; }

        public void SetNameGroup(String nameGroup)
        {
            NameGroupStudent = nameGroup;
        }
        public String GetNameGroup() { return NameGroupStudent; }

        public ContinueQuest(String nameStudent,String nameGroup)
        {
            SetNameStudent(nameStudent);
            SetNameGroup(nameGroup);
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            LogInAsStudent logAsStudent = new LogInAsStudent();
            this.Close();
            logAsStudent.Show();
        }
    }
}
