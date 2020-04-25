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
        public virtual DbSet<BillProcedureDetail> BillProcedureDetails { get; set; }
        public virtual DbSet<BillProcedure> BillProcedures { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DoctorBookClosing> DoctorBookClosings { get; set; }
        public virtual DbSet<DoctorDepartment> DoctorDepartments { get; set; }
        public virtual DbSet<PrinterInfo> PrinterInfoes { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorShareConfiguration> DoctorShareConfigurations { get; set; }
        public virtual DbSet<DoctorShareConfigurationHistory> DoctorShareConfigurationHistories { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Investor> Investors { get; set; }
        public virtual DbSet<InvestorShareConfiguration> InvestorShareConfigurations { get; set; }
        public virtual DbSet<InvestorShareConfigurationHistory> InvestorShareConfigurationHistories { get; set; }
        public virtual DbSet<log> logs { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<ProcedureReturn> ProcedureReturns { get; set; }
        public virtual DbSet<Procedure> Procedures { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Salary> Salaries { get; set; }
        public virtual DbSet<ServiceReturn> ServiceReturns { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
                .HasMany(e => e.ServiceReturns)
                .WithRequired(e => e.Bill)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillDetail>()
                .HasMany(e => e.ServiceReturns)
                .WithRequired(e => e.BillDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BillProcedureDetail>()
                .HasMany(e => e.ProcedureReturns)
                .WithRequired(e => e.BillProcedureDetail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DoctorDepartment>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.DoctorDepartment)
                .HasForeignKey(e => e.departmentId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .Property(e => e.credentials)
                .IsUnicode(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.BillProcedureDetails)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.DoctorBookClosings)
                .WithOptional(e => e.Doctor)
                .HasForeignKey(e => e.docId);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.DoctorShareConfigurations)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.DoctorShareConfigurationHistories)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.ProcedureReturns)
                .WithRequired(e => e.Doctor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Tokens)
                .WithOptional(e => e.Doctor)
                .HasForeignKey(e => e.docId);

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

            modelBuilder.Entity<Investor>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<Investor>()
                .HasMany(e => e.InvestorShareConfigurations)
                .WithRequired(e => e.Investor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<log>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<log>()
                .Property(e => e.previousValue)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.ServiceReturns)
                .WithRequired(e => e.Patient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcedureReturn>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<Procedure>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Procedure>()
                .HasMany(e => e.BillProcedureDetails)
                .WithRequired(e => e.Procedure)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServiceReturn>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.BillDetails)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.InvestorShareConfigurations)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.InvestorShareConfigurationHistories)
                .WithRequired(e => e.Service)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.ServiceReturns)
                .WithRequired(e => e.Service)
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
                .HasMany(e => e.BillProcedures)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BillProcedures1)
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
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Doctors1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorShareConfigurations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorShareConfigurations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorShareConfigurationHistories)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employees)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.createdBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Employees1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Investors)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Investors1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InvestorShareConfigurations)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InvestorShareConfigurations1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.modifiedBy);

            modelBuilder.Entity<User>()
                .HasMany(e => e.InvestorShareConfigurationHistories)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.ProcedureReturns)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ServiceReturns)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

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

            modelBuilder.Entity<User>()
                .HasMany(e => e.Vouchers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.createdBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.referenceData)
                .IsUnicode(false);
        }
    }
}
