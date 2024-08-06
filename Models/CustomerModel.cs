using System.ComponentModel.DataAnnotations;

namespace SampleTest.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }       
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }        
    }
}
