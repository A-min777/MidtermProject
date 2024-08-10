namespace MidtermProject.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Member()
        {
            PurchaseRecords = new HashSet<PurchaseRecord>();
        }

        public int Id { get; set; }

        public int MembershipId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? Gender { get; set; }

        public int? Age { get; set; }

        public DateTime? Birthday { get; set; }

        public decimal TotalSpent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchaseRecord> PurchaseRecords { get; set; }
    }
}
