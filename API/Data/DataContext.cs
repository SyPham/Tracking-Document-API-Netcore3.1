using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<NotificationDetail> NotificationDetails { get; set; }
        public DbSet<ColorCode> ColorCodes { get; set; }
        public DbSet<DepartmentManger> DepartmentMangers { get; set; }
        public DbSet<PermissionDetail> PermissionDetails { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }

        public DbSet<CategoryLang> CategoryLangs { get; set; }
        public DbSet<SubCategoryLang> SubCategoryLangs{ get; set; }
        public DbSet<DepartmentLang> DepartmentLangs { get; set; }
        public DbSet<LocationLang> LocationLangs { get; set; }
        public DbSet<StatusLang> StatusLangs { get; set; }
        public DbSet<TeamLang> TeamLangs { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public DbSet<History> Histories { get; set; }


    }
}