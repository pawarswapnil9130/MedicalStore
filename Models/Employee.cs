using System.ComponentModel.DataAnnotations;

namespace MedicalStore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

}
