using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using D05.Models;

namespace D05.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160222032154_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("D05.Models.Ticket", b =>
                {
                    b.HasOne("D05.Models.Transaction")
                        .WithMany()
                        .HasForeignKey("TransactionID");
                });
        }
    }
}
