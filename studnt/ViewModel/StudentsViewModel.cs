using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using studnt.Model;

#nullable disable

namespace studnt.ViewModel
{
    public partial class StudentsViewModel :ObservableObject
    {
        [ObservableProperty]
        public string sfirstName;
        [ObservableProperty]
        public string ssecondName;
        [ObservableProperty]
        public string sregistrationNumber;
        [ObservableProperty]
        public string sacdemicYear;

        [ObservableProperty]
        ObservableCollection<Students> students;

        [RelayCommand]

        public void InsertStudent()
        {
            Students s =new Students();
            {
                SfirstName = SfirstName;  //variables defined under observable poperties, when generated after calling the constructor,the new variables start with a capital letter first
                                          //for example  "sfistName" is declared above,when generated it has the name "SfirstName" where the first letter is capital
                SsecondName = SsecondName;
                SregistrationNumber = SregistrationNumber;
                SacdemicYear = SacdemicYear;
               

            };
            using (var db=new DataContext())
            {
                db.Students.Add(s);
                db.SaveChanges();
            }

            LoadStudent();
        }

        public void LoadStudent()
        {
            using (var db = new DataContext())
            {
                var list = db.Students.OrderByDescending(s =>   SfirstName ).ToList();
                Students = new ObservableCollection<Students>(list);
            }

        }

        public StudentsViewModel()
        {
            LoadStudent();
        }

    }

    
}
