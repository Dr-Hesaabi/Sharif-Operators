namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesOfficer")]
    public partial class SalesOfficer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string NationalCode { get; set; }

        public int BusinessId { get; set; }

        public virtual Business Business { get; set; }

        public virtual User User { get; set; }
    }
}
