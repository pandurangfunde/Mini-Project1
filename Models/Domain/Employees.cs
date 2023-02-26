namespace EmployeeS.Models.Domain
{
    public class Employees
    {
        public Guid Id { get; set; }

        public String Name { get; set; }
        public String Email { get; set; }

        public Double Salary { get; set; }

        public DateTime DateOfBirth { get; set; } 

        public String Department { get; set; }

       
    }
}
