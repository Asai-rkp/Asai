

namespace Student_Management_App_1.Models
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public int Tamil { get; set; }
        public int English { get; set; }
        public int Maths { get; set; }

        public int Total => Tamil + English + Maths;
    }
}
