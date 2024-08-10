namespace MidtermProject.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Membership
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string MembershipLevel { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
