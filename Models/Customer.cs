using System.ComponentModel.DataAnnotations;

namespace MedicalStore.Models
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }

}
