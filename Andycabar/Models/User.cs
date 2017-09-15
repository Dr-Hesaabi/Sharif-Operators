namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int? VerificationCode { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Marketer Marketer { get; set; }

        public virtual SalesOfficer SalesOfficer { get; set; }

        public virtual Seller Seller { get; set; }
    }
}
