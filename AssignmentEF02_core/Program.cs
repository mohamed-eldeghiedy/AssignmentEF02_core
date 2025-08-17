using AssignmentEF02_core.context;
using AssignmentEF02_core.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEF02_core
{
    internal class Program
    {
        static void Main()
        {



            #region CRUD Operations

           
            using (var db = new ITIDbContext())
            {

                var dept = db.Departments.FirstOrDefault(d => d.Name == "IT");
                if (dept == null)
                {
                    dept = new Department { Name = "IT", HLocation = "Cairo", MgrName = "Zain" };
                    db.Departments.Add(dept);
                    db.SaveChanges();
                }

                var students = new List<Student>
                {
                    new Student { FName = "Mohamed", LName = "Ahmed", Age = 23, Address = "Cairo", DeptId = dept.Id },
                    new Student { FName = "Mona", LName = "Adel", Age = 22, Address = "Giza", DeptId = dept.Id },
                    new Student { FName = "Mustafa", LName = "Mohamed", Age = 18, Address = "Mansoura", DeptId = dept.Id }
                };

                db.Students.AddRange(students);
                db.SaveChanges();

                Console.WriteLine(" Department and Students added successfully!");
            }

            using (var db = new ITIDbContext())
            {
                var students = db.Students
                                 .Include(s => s.Department)   
                                 .ToList();

                Console.WriteLine("📌 Students List:");
                foreach (var s in students)
                {
                    Console.WriteLine($"{s.FName} {s.LName} - Dept: {s.Department.Name}");
                }
            }

            
            using (var db = new ITIDbContext())
            {
                var student = db.Students.First();
                student.FName = "UpdatedName";
                db.SaveChanges();

                Console.WriteLine(" Student updated successfully!");
            }

            using (var db = new ITIDbContext())
            {
                var student = db.Students.First();
                db.Students.Remove(student);
                db.SaveChanges();

                Console.WriteLine(" Student deleted successfully!");
            }




            #endregion

        }
    }
}
