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
    /// Interaction logic for InstructorDashboard.xaml
    /// </summary>
    public partial class InstructorDashboard : Window
    {
        public InstructorDashboard()
        {
            InitializeComponent();
        }

        private void addNewStudent_Click(object sender, RoutedEventArgs e)
        {
            AddNewStudent addNewStudent = new AddNewStudent();
            addNewStudent.Show();
            Close();
        }

  
        private void addNewModule_Click(object sender, RoutedEventArgs e)
        {
            AddNewModule addNewModule = new AddNewModule();
            addNewModule.Show();
            Close();
        }

        private void removeStudent_Click(object sender, RoutedEventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            removeStudent.Show();
            Close ();
        }

        private void deleteModule_Click(object sender, RoutedEventArgs e)
        {
            DeleteModule deleteModule = new DeleteModule();
            deleteModule.Show();
            Close();
        }

        private void tSudentList_Click(object sender, RoutedEventArgs e)
        {
            TotalStudentList totalStudent= new TotalStudentList();
            totalStudent.Show();
            Close();
        }

        private void tModuleList_Click(object sender, RoutedEventArgs e)
        {
            TotalModuleList totalModuleList= new TotalModuleList();
            totalModuleList.Show();
            Close();
        }

        private void updateStudentDetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updateModuleDetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void calculateTheGPA_Click(object sender, RoutedEventArgs e)
        {

        }

        private void removeModule_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            InstructorLogin instructorLogin = new InstructorLogin();
            instructorLogin.Show();
            Close();
        }
    }
}
