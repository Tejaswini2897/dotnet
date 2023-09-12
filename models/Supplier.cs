using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProductSupplierAPIs.models
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [EmailAddress]
        public string Email{ get; set; }
        [StringLength(10,MinimumLength =10,ErrorMessage ="phone number must be 10 digit"),DisplayFormat="1234567890"]


        public string Phone { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
