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
    /// Interaction logic for DeleteModule.xaml
    /// </summary>
    public partial class DeleteModule : Window
    {
        public DeleteModule()
        {
            InitializeComponent();
        }

        public List<Modules> ?Modules { get; private set; }

        private void deleteTheModule_Click(object sender, RoutedEventArgs e)
        {
            using (ViewModel.DataContext context = new ViewModel.DataContext())
            {
                var ModuletoDelte = DelModuleCode.Text;
                Modules = context.Modules.ToList();
                var todelete = Modules.Find(x => x.ModuleCode == ModuletoDelte);

                if (todelete!=null)
                {
                    context.Remove(todelete);
                    context.SaveChanges();

                    DelModuleCode.Text = null;
                    MessageBox.Show("deleted succesfully");
                }
                else
                {
                    MessageBox.Show("invalid modulecode");
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
