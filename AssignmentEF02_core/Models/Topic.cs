namespace AssignmentEF02_core.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}