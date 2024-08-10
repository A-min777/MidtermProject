namespace MidtermProject.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PurchaseRecord
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public int? Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PurchaseDate { get; set; }

        public virtual Member Member { get; set; }
    }
}
