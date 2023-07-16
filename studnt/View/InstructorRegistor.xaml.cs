using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for InstructorRegistor.xaml
    /// </summary>
    public partial class InstructorRegistor : Window
    {
        public InstructorRegistor()
        {
            InitializeComponent();
        }

        private void registerInstructor_Click(object sender, RoutedEventArgs e)
        {
            //add the instructor to the data base
            //Create

            using (ViewModel.DataContext context = new ViewModel.DataContext())

            {

                

                var InFName = IFirstName.Text;
                var InSName =ISecondName.Text;
                var InCode =ICode.Text;
                var InModuleCode = IModuleCode.Text;

                if (InFName!=null && InSName !=null && InCode !=null && InModuleCode !=null)
                {
                    context.Instructors.Add(new Model.Instructors()
                    {

                        IFirstName = InFName,
                        ISecondName = InSName,
                        IInstructorCode = InCode,
                        IModuleCode = InModuleCode,

                    });

                    context.SaveChanges();

                    IFirstName.Text = null;
                    ISecondName.Text = null;
                    ICode.Text = null;
                    IModuleCode.Text = null;
                    

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
            InstructorLogin instructorLogin = new InstructorLogin();
            instructorLogin.Show();
            Close();
        }
    }
}
