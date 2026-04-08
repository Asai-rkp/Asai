
using System.Collections.ObjectModel;
using Student_Management_App_1.Models;

namespace Student_Management_App_1.ViewModels
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students { get; set; }

        public StudentViewModel()
        {
            Students = new ObservableCollection<Student>
            {
                new Student { Name="Asai", Age=19, Department="CSE", Tamil=80, English=85, Maths=90 },
                new Student { Name="Dushyanth", Age=20, Department="IT", Tamil=75, English=88, Maths=92 },
                new Student { Name="Nithinaa", Age=21, Department="ECE", Tamil=70, English=78, Maths=85 }
            };
        }
    }
}
