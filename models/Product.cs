using Microsoft.EntityFrameworkCore;
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
        public string Description { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
        public bool IsDelete { get; set; }
        public ICollection<Supplier>? Supplier { get; set; }
        public int SupplierID { get; set; }
    }
}
