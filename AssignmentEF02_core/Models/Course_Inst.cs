namespace AssignmentEF02_core.Models
{
    public class Course_Inst
    {
        public int InstId { get; set; }
        public Instructor Instructor { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}