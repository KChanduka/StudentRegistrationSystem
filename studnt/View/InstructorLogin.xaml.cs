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
    /// Interaction logic for InstructorLogin.xaml
    /// </summary>
    public partial class InstructorLogin : Window
    {
        public InstructorLogin()
        {
            InitializeComponent();
        }
  
       
        //sign in new instructor
        private void loginTheInstructor_Click(object sender, RoutedEventArgs e)



        {

            //user name and pass
            var InstructorUserName = InsUserName.Text;
            var InstructorPassword = InsPassword.Text;
            
            
            
            //check wehther the instrucctor is in the database
            using (ViewModel.DataContext context = new ViewModel.DataContext())
            {
                //here the userfound is true if the student f name is the user name
                bool userFound = context.Instructors.Any(instructor => instructor.IFirstName == InstructorUserName &&  instructor.IInstructorCode == InstructorPassword);

                if (userFound)
                {
                    GiveAccess();
                    Close();
                }

                else
                {
                    MessageBox.Show("Instructor Not Found ,Please feel free to Register!");
                }
                InsUserName.Text = null;
                InsPassword.Text = null;




            }


            //if true

            
        }
        public void GiveAccess()
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard();
            instructorDashboard.Show();
        }


        //regidter new instructor
        private void registerNewInstructor_Click(object sender, RoutedEventArgs e)
        {
            InstructorRegistor instructorRegistor = new InstructorRegistor();
            instructorRegistor.Show();
            Close();

        }

        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
    }
}
