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
using studnt.Model;
using studnt.ViewModel;

namespace studnt.View
{
    /// <summary>
    /// Interaction logic for TotalModuleList.xaml
    /// </summary>
    public partial class TotalModuleList : Window
    {
        public TotalModuleList()
        {
           
            InitializeComponent();
            DataTest2();
        }

        public List<Modules> MyModule { get; set; }

        public void DataTest2()
        {
            using (DataContext context = new DataContext())
            {
                var MyModule = context.Modules.ToList();

            }
                ModuleGrid.ItemsSource = MyModule;
        }

        private void Back_App_Click(object sender, RoutedEventArgs e)
        {
            InstructorDashboard instructorDashboard = new InstructorDashboard();
            instructorDashboard.Show();
            Close();
        }

    }
}
