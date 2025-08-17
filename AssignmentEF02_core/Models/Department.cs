namespace AssignmentEF02_core.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HLocation { get; set; }
        public string MgrName { get; set; }

       
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }
    }
}