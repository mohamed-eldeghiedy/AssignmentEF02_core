namespace AssignmentEF02_core.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }

        public int DeptId { get; set; }
       
        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}