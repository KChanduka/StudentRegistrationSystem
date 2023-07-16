using studnt.Model;
using studnt.ViewModel;
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
using System.Windows.Shapes;

namespace studnt.View
{
    /// <summary>
    /// Interaction logic for StudentDashboard.xaml
    /// </summary>
    public partial class StudentDashboard : Window
    {
        public StudentDashboard()
        {
            InitializeComponent();
            DataTest1();
            DataContext = myStudent;
        }


        private Students myStudent;

        private void DataTest1()
        {
            using (DataContext context = new DataContext())
            {
                List<Students> students = context.Students.ToList();
                myStudent = students.Find(x => x.SRegistrationNumbrer == StudentLogin.instance2.StudentPassword.Text);
            }
        }

        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            StudentLogin studentlogin = new StudentLogin();
            studentlogin.Show();
            Close();
        }

    }
}
