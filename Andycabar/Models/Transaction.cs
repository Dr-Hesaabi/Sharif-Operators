namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transaction()
        {
            Associtation_TransactionProduct = new HashSet<Associtation_TransactionProduct>();
        }

        public int Id { get; set; }

        public decimal Amount { get; set; }

        public DateTime Submit { get; set; }

        public int CustomerId { get; set; }

        public int? SellerId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Associtation_TransactionProduct> Associtation_TransactionProduct { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
