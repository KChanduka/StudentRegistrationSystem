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
    /// Interaction logic for AddNewModule.xaml
    /// </summary>
    public partial class AddNewModule : Window
    {
        public AddNewModule()
        {
            InitializeComponent();
        }

        private void addTheModule_Click(object sender, RoutedEventArgs e)
        {

            using (ViewModel.DataContext context = new ViewModel.DataContext())
            {
                var modulename = AddModuleName.Text;
                var modulecode = AddModuleCode.Text;

                if (modulecode!=null && modulename != null)
                {
                    context.Modules.Add(new Model.Modules() { ModuleCode=modulecode,Modulename=modulename });
                    context.SaveChanges();

                    AddModuleName.Text = null;
                    AddModuleCode.Text = null;

                    MessageBox.Show("added succsesfully");
                }
                else
                {
                    MessageBox.Show("Fill all the fields");
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
