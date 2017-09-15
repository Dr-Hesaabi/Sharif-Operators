namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductTransfer")]
    public partial class ProductTransfer
    {
        [Key]
        [StringLength(50)]
        public string Barcode { get; set; }

        public long ProductId { get; set; }

        public DateTime ProduceEvent { get; set; }

        public DateTime EntranceEvent { get; set; }

        public DateTime BarcodeEvent { get; set; }

        public DateTime SaleEvent { get; set; }

        public DateTime SubmitEvent { get; set; }

        public DateTime ExpireEvent { get; set; }

        public virtual Product Product { get; set; }
    }
}
