namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Store")]
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            ProductTransfers = new HashSet<ProductTransfer>();
            Sellers = new HashSet<Seller>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        [StringLength(4000)]
        public string Address { get; set; }

        public byte[] Logo { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductTransfer> ProductTransfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Seller> Sellers { get; set; }
    }
}
