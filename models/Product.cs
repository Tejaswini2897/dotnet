using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace ProductSupplierAPIs.models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name {  get; set; }
        [StringLength(100,ErrorMessage ="Description should be less than or eaqul to 100 characters")]
        public string Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public bool? IsDelete { get; set; }
        public ICollection<Supplier>? Supplier { get; set; }
        [ForeignKey("SupplierID")]
        public int SupplierID { get; set; }
    }
}
