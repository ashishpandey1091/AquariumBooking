using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using D05.Models;

namespace D05.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("D05.Controllers.Coupons", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CouponString");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("ExpireDate");

                    b.HasKey("CouponID");
                });

            modelBuilder.Entity("D05.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.HasKey("AdminID");
                });

            modelBuilder.Entity("D05.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("D05.Models.CouponProfile", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CouponID");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("isUsed");

                    b.HasKey("ProfileID");
                });

            modelBuilder.Entity("D05.Models.CreateEvent", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AdultPrice");

                    b.Property<double>("Child");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("EventName")
                        .IsRequired();

                    b.Property<double>("SeniorCitizen");

                    b.Property<bool>("SpecialEvent");

                    b.HasKey("EventID");
                });

            modelBuilder.Entity("D05.Models.Profile", b =>
                {
                    b.Property<int>("ProfileID");

                    b.Property<int>("Age");

                    b.Property<string>("Answer");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PersonalCoup");

                    b.Property<string>("Question");

                    b.HasKey("ProfileID");
                });

            modelBuilder.Entity("D05.Models.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TicketGeneratedDate");

                    b.Property<string>("TicketType")
                        .IsRequired();

                    b.Property<int>("TransactionID");

                    b.Property<DateTime>("VisitReason");

                    b.Property<DateTime>("VisitingDate");

                    b.Property<DateTime>("VisitingTime");

                    b.HasKey("TicketID");
                });

            modelBuilder.Entity("D05.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionID");

                    b.Property<string>("CreatedByEmail");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<double>("PaidAmount");

                    b.Property<double>("TotalAmount");

                    b.Property<string>("UsedCoupon");

                    b.HasKey("TransactionID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("D05.Models.Ticket", b =>
                {
                    b.HasOne("D05.Models.Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionID");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("D05.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("D05.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("D05.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
        }
    }
}
