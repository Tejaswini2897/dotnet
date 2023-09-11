using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ProductSupplierAPIs.models
{
    public class Supplier
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email{ get; set; }
        public string Phone { get; set; }
        
        public ICollection<Product>? Products { get; set; }
    }
}
