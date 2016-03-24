using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using D05.Models;

namespace D05.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160324180146_MigrateData")]
    partial class MigrateData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("D05.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("Age");

                    b.Property<string>("Answer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Question");

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

            modelBuilder.Entity("D05.Models.BirthdayParty", b =>
                {
                    b.Property<int>("BirthdayPartyID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttendeesNumber");

                    b.Property<int>("BirthdayPersonAge");

                    b.Property<string>("BirthdayPersonName")
                        .IsRequired();

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("DateofVisit");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("FoodDetails");

                    b.Property<string>("IsAdminAccepted")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.HasKey("BirthdayPartyID");
                });

            modelBuilder.Entity("D05.Models.Coupon", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CouponNumber")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<decimal>("PriceReduced");

                    b.HasKey("CouponID");
                });

            modelBuilder.Entity("D05.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdultPrice");

                    b.Property<decimal>("ChildPrice");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EventDate");

                    b.Property<string>("EventEndTime");

                    b.Property<string>("EventName")
                        .IsRequired();

                    b.Property<string>("EventStartTime");

                    b.Property<bool>("IsSpecialEvent");

                    b.Property<decimal>("OldAgePrice");

                    b.HasKey("EventID");
                });

            modelBuilder.Entity("D05.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("DateOfVisit");

                    b.Property<decimal>("EntryTicketPrice");

                    b.Property<decimal>("OrderTotalPrice");

                    b.Property<decimal>("SpecialEventPrice");

                    b.Property<DateTime>("TicketGeneratedDate");

                    b.Property<string>("VisitorEmail");

                    b.Property<string>("VisitorFN");

                    b.HasKey("OrderDetailID");
                });

            modelBuilder.Entity("D05.Models.Price", b =>
                {
                    b.Property<int>("PriceID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AdultPrice");

                    b.Property<decimal>("ChildPrice");

                    b.Property<decimal>("OldAgePrice");

                    b.HasKey("PriceID");
                });

            modelBuilder.Entity("D05.Models.SchoolTrip", b =>
                {
                    b.Property<int>("SchoolTripID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("DateofRegistration");

                    b.Property<DateTime>("DateofVisit");

                    b.Property<string>("Details")
                        .IsRequired();

                    b.Property<string>("IsAdminAccepted")
                        .IsRequired();

                    b.Property<int>("NoOfAdults");

                    b.Property<int>("NoOfChildren");

                    b.Property<string>("SchoolAddress")
                        .IsRequired();

                    b.Property<string>("SchoolEmail")
                        .IsRequired();

                    b.Property<string>("SchoolName")
                        .IsRequired();

                    b.HasKey("SchoolTripID");
                });

            modelBuilder.Entity("D05.Models.SleepOver", b =>
                {
                    b.Property<int>("SleepOverID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AttendeesNumber");

                    b.Property<int>("ContactNumber");

                    b.Property<DateTime>("DateofVisit");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("IsAdminAccepted")
                        .IsRequired();

                    b.Property<bool>("IsNeedInFood");

                    b.Property<bool>("IsNeedInMattress");

                    b.Property<bool>("IsNeedInVR");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("UserEmail")
                        .IsRequired();

                    b.HasKey("SleepOverID");
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

            modelBuilder.Entity("D05.Models.OrderDetail", b =>
                {
                    b.HasOne("D05.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
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
