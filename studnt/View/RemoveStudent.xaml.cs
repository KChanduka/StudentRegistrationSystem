using studnt.Model;
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
    /// Interaction logic for RemoveStudent.xaml
    /// </summary>
    public partial class RemoveStudent : Window
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        public List<Students> ?students { get; private set; }

        private void removeTheStudent_Click(object sender, RoutedEventArgs e)
        {
            using(ViewModel.DataContext context= new ViewModel.DataContext())
            {
                students = context.Students.ToList(); //adding the students into a list to search for the registration number
                var regNumToRemove = regNum.Text;     //getting the registration number from the textbox
                var toremove =students.Find(x => x.SRegistrationNumbrer==regNumToRemove);//finding and adding the student to remove, to the variable "toremove"


                if (toremove!=null)
                 {
                    
                    
                    context.Remove(toremove);
                    context.SaveChanges();
                    MessageBox.Show("removed succesfully");
                   
                }
                else
                {
                    MessageBox.Show("Invalid Registration Number ");
                }
            }

        }

        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard();
            instructorDashboard.Show();
            Close();
        }
    }
}
