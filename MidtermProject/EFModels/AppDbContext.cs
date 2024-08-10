using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MidtermProject.EFModels
{
	public partial class AppDbContext : DbContext
	{
		public AppDbContext()
			: base("name=AppDbContext")
		{
		}

		public virtual DbSet<Admin> Admins { get; set; }
		public virtual DbSet<Member> Members { get; set; }
		public virtual DbSet<Membership> Memberships { get; set; }
		public virtual DbSet<PurchaseRecord> PurchaseRecords { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Member>()
				.Property(e => e.TotalSpent)
				.HasPrecision(10, 2);
		}
	}
}
