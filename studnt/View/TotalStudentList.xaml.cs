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
using System.Data.SqlClient;
using studnt.Model;
using studnt.ViewModel;


namespace studnt.View
{
    /// <summary>
    /// Interaction logic for TotalStudentList.xaml
    /// </summary>
    /// 
    
public partial class TotalStudentList : Window
    {

        public TotalStudentList()

        {
    
            InitializeComponent();
            DataTest1();
            
        }
        public List<Students> MyStudents { get; set; }

        private void DataTest1()
        {
            using (DataContext context = new DataContext())
            {
                MyStudents = context.Students.ToList();
            }
            StudentGrid.ItemsSource = MyStudents;
        }


        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard();
            instructorDashboard.Show();
            Close();
        }

    }
}
