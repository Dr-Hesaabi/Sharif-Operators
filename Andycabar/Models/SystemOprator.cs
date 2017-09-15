namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemOprator")]
    public partial class SystemOprator
    {
        [Key]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(4000)]
        public string Password { get; set; }
    }
}
