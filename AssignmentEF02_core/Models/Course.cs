namespace AssignmentEF02_core.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        
        public int TopId { get; set; }
        public Topic Topic { get; set; }

       
        public ICollection<Stud_Course> Stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}