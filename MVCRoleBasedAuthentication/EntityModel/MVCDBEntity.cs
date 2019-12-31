namespace MVCRoleBasedAuthentication.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVCDBEntity : DbContext
    {
        public MVCDBEntity()
            : base("name=MVCDBEntity")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<RoleMaster> RoleMasters { get; set; }
        public virtual DbSet<UserRolesMapping> UserRolesMappings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Designation)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMaster>()
                .Property(e => e.RollName)
                .IsUnicode(false);

            modelBuilder.Entity<RoleMaster>()
                .HasMany(e => e.UserRolesMappings)
                .WithRequired(e => e.RoleMaster)
                .HasForeignKey(e => e.RoleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserRolesMappings)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
