namespace ShifaClinic.DataContext
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class clinicDbContext : DbContext
    {
        public clinicDbContext()
            : base("name=clinicDbContext")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DoctorDepartment> DoctorDepartments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoctorDepartment>()
                .HasMany(e => e.Doctors)
                .WithOptional(e => e.DoctorDepartment)
                .HasForeignKey(e => e.departmentId);

            modelBuilder.Entity<Employee>()
                .Property(e => e.presentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.permanentAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Salaries)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.previousValue)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.mobileName)
                .IsFixedLength();

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Bills1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Designations)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Designations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorDepartments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorDepartments1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.logs)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Patients)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Patients1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Services1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users11)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.modifiedBy);
        }
    }
}
