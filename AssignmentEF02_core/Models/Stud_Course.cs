namespace AssignmentEF02_core.Models
{
    public class Stud_Course
    {
        public int StudId { get; set; }
        public Student Student { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }

        public decimal Grade { get; set; }
    }
}