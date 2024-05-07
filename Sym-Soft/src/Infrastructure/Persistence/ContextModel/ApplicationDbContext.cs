using System.Data;

namespace Persistence.ContextModel;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, long, IdentityUserClaim<long>, ApplicationUserRole, IdentityUserLogin<long>, IdentityRoleClaim<long>, IdentityUserToken<long>>
{
    #region Config
    public long CurrentUserId { get; set; }
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    #endregion

    #region Db_Entity

    #region Admin

    public DbSet<Department> Departments { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<SetCountry> SetCountries { get; set; }
    public DbSet<SetCurrency> SetCurrencies { get; set; }
    public DbSet<SetDistrict> SetDistricts { get; set; }
    public DbSet<SetDivision> SetDivisions { get; set; }
    public DbSet<SetFincYear> SetFincYears { get; set; }
    public DbSet<SetHoliday> SetHolidays { get; set; }
    public DbSet<SetPoliceStation> SetPoliceStations { get; set; }
    public DbSet<SetShift> SetShifts { get; set; }

    #endregion

    #region Hr
    public DbSet<EmpDisciplinary> EmpDisciplinaries { get; set; }
    public DbSet<EmpEducation> EmpEducations { get; set; }
    public DbSet<EmpExperience> EmpExperiences { get; set; }
    public DbSet<EmpJournal> EmpJournals { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmpPosting> EmpPostings { get; set; }
    public DbSet<EmpReference> EmpReferences { get; set; }
    public DbSet<EmpTraining> EmpTraining { get; set; }
    public DbSet<HrSetting> HrSettings { get; set; }

    #endregion

    #region Attendance
    public DbSet<DutyShift> DutyShifts { get; set; }
    public DbSet<ShiftManagement> ShiftManagements { get; set; }
    public DbSet<EmpAttendance> EmpAttendances { get; set; }

    #endregion

    #region Leave

    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveSetup> LeaveSetups { get; set; }
    public DbSet<LeaveCf> LeaveCfs { get; set; }
    public DbSet<EmpLeaveApplication> EmpLeaveApplications { get; set; }
    public DbSet<DptLeaveReviewer> DptLeaveReviewers { get; set; }
    public DbSet<EmpLeaveReviewer> EmpLeaveReviewers { get; set; }
    public DbSet<LvAppReviewer> LvAppReviewers { get; set; }
    public DbSet<LvTransferHst> LvTransferHsts { get; set; }

    #endregion

    #region Inventory

    public DbSet<CategoryInfo> CategoryInfos { get; set; }
    public DbSet<ItemInfo> ItemInfos { get; set; }
    public DbSet<NoteInfo> NoteInfos { get; set; }
    public DbSet<OrderDtl> OrderDtls { get; set; }
    public DbSet<OrderMst> OrderMsts { get; set; }
    public DbSet<RequsitionInfo> RequsitionInfos { get; set; }
    public DbSet<RequsitionInfoDtl> RequsitionInfoDtls { get; set; }
    public DbSet<SupplierInfo> SupplierInfos { get; set; }
    public DbSet<TranDtl> TranDtls { get; set; }
    public DbSet<TranMst> TranMsts { get; set; }
    public DbSet<UnitInfo> UnitInfos { get; set; }
    public DbSet<InventoryBillPayment> InventoryBillPayments { get; set; }

    #endregion

    #region Payroll

    public DbSet<SetSalaryGrade> SetSalaryGrades { get; set; }
    public DbSet<MonthlyAttendanceSheetMst> MonthlyAttendanceSheetMsts { get; set; }
    public DbSet<MonthlyAttendanceSheetDtl> MonthlyAttendanceSheetDtls { get; set; }
    public DbSet<PrSalaryPart> PrSalaryParts { get; set; }
    public DbSet<PrEmpSalaryPart> PrEmpSalaryParts { get; set; }
    public DbSet<PrSalaryMst> PrSalaryMsts { get; set; }
    public DbSet<PrSalaryDtl> PrSalaryDtls { get; set; }
    public DbSet<PrArrearMst> PrArrearMsts { get; set; }
    public DbSet<PrArrearDtl> PrArrearDtls { get; set; }
    public DbSet<PrGuestSalaryMst> PrGuestSalaryMsts { get; set; }
    public DbSet<PrGuestSalaryDtl> PrGuestSalaryDtls { get; set; }

    #endregion

    #region PF

    public DbSet<PfSetting> PfSettings { get; set; }
    public DbSet<PfBoardMember> PfBoardMembers { get; set; }
    public DbSet<PfFundOpenning> PfFundOpennings { get; set; }
    public DbSet<PfFundMst> PfFundMsts { get; set; }
    public DbSet<PfFundDtl> PfFundDtls { get; set; }
    public DbSet<PfSettlement> PfSettlements { get; set; }
    public DbSet<EmpLoanMst> EmpLoanMsts { get; set; }
    public DbSet<EmpLoanDtl> EmpLoanDtls { get; set; }

    #endregion

    #region Accounting
    public DbSet<AccGroup> AccGroups { get; set; }
    public DbSet<AccHead> AccHeads { get; set; }
    public DbSet<AccLedger> AccLedgers { get; set; }
    public DbSet<AccTranMst> AccTranMsts { get; set; }
    public DbSet<AccTranDtl> AccTranDtls { get; set; }
    public DbSet<AccTranNote> AccTranNotes { get; set; }
    public DbSet<AccTranFile> AccTranFiles { get; set; }
    public DbSet<AccReviewer> AccReviewers { get; set; }

    #endregion

    #region Notice

    public DbSet<NoticeInfo> NoticeInfos { get; set; }

    #endregion

    #endregion

    public IDbConnection Connection => Database.GetDbConnection();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<ApplicationUserRole>(userRole =>
        {
            userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

            userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

            userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
        });

        modelBuilder.Entity<RequsitionInfoDtl>()
                .HasOne<RequsitionInfo>(s => s.Req)
                .WithMany(g => g.RequsitionInfoDtls)
                .HasForeignKey(s => s.ReqId);

        modelBuilder.Entity<OrderDtl>()
            .HasOne<OrderMst>(s => s.Order)
            .WithMany(g => g.OrderDtls)
            .HasForeignKey(s => s.OrderId);

        modelBuilder.Entity<OrderDtl>()
                .HasOne<OrderMst>(s => s.LastOrder)
                .WithMany()
                .HasForeignKey(s => s.LastOrderId);

        foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }

        //AllDefaultValueSeedData.SetConfig(modelBuilder);
        //modelBuilder.HasDefaultSchema("dbo");
    }


}
