using System.Reflection;
using Microsoft.EntityFrameworkCore;
using waste_track_sa_core.Entities;

namespace waste_track_sa_infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<API> APIs { get; set; }
        public DbSet<APIAccess> APIAccesses { get; set; }
        public DbSet<CardPrintWastePicker> CardPrintWastePickers { get; set; }
        public DbSet<Cooperative> Cooperatives { get; set; }
        public DbSet<CooperativeInfo> CooperativeInfo { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<EmailContent> GetEmailContents { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<IncomeMethod> IncomeMethods { get; set; }
        public DbSet<MasterCode> MasterCodes { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public DbSet<OfficialType> OfficialTypes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<ReclaimingInfo> ReclaimingInfo { get; set; }
        public DbSet<SortingArea> SortingAreas { get; set; }
        public DbSet<SystemLog> SystemLogs { get; set; }
        public DbSet<SystemSetting> SystemSettings { get; set; }
        public DbSet<ThirdPartySystem> ThirdPartySystems { get; set; }
        public DbSet<ThirdPartySystemLog> ThirdPartySystemLogs { get; set; }
        public DbSet<ToBeUpdatedWastePicker> ToBeUpdatedWastePickers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserSession> UserSessions { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<WastePicker> WastePickers { get; set; }
        public DbSet<WastePickerActivityLog> WastePickerActivityLogs { get; set; }
        public DbSet<WastePickerDocument> WastePickerDocuments { get; set; }
        public DbSet<WastePickerStatus> WastePickerStatuses { get; set; }
        public DbSet<WastePickerStatusAudit> GetWastePickerStatusAudits { get; set; }
        public DbSet<Worksite> Worksites { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}