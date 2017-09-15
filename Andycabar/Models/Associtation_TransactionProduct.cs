namespace Andycabar.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Associtation_TransactionProduct
    {
        public int Id { get; set; }

        public long ProductId { get; set; }

        public int TransactionId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Transaction Transaction { get; set; }
    }
}
