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
    /// Interaction logic for AddNewStudent.xaml
    /// </summary>
    public partial class AddNewStudent : Window
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void addTheStudent_Click(object sender, RoutedEventArgs e)
        {
            
            //create a new student by adding a new student to the data base
            using( ViewModel.DataContext context = new ViewModel.DataContext())
            {
                //craete the model properties
                var SFname = SFirstName.Text;
                var SSName = SSecondName.Text;
                var SRegNo = SRegistrationNo.Text;
                var SAccYear = SAccademicYear.Text;

                //checck

                if (SFname != null && SSName !=null && SRegNo !=null && SAccYear!=null)
                {
                    context.Students.Add(new Model.Students()

                    {

                        SFirstName = SFname,
                        SSecondName = SSName,
                        SRegistrationNumbrer = SRegNo,
                        SAcadenicYear = SAccYear
                    });

                    context.SaveChanges();

                    SFirstName.Text=null;
                    SSecondName.Text = null;
                    SRegistrationNo.Text = null;
                    SAccademicYear.Text = null;

                    MessageBox.Show("Added the details sucessfull!");
                }

                else
                {
                    MessageBox.Show("Fill All the feilds");
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
