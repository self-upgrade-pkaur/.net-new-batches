using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Data.Entities
{
    public partial class ContactDbContext : DbContext
    {
        public ContactDbContext()
        {
        }

        public ContactDbContext(DbContextOptions<ContactDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<MoreInfo> MoreInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=testdb-uta.database.windows.net;Database=ContactDb;user id=pushpinder;Password=Password123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Add1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_Address_Contact");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Home)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Work)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MoreInfo>(entity =>
            {
                entity.Property(e => e.Company)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("created")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dob).HasColumnType("date");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.MoreInfo)
                    .HasForeignKey(d => d.ContactId)
                    .HasConstraintName("FK_MoreInfo_Contact");
            });
        }
    }
}
