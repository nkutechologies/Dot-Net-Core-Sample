﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RWFOUNDATIONWebsite.Data;

namespace RWFOUNDATIONWebsite.Migrations
{
    [DbContext(typeof(RwDbContext))]
    [Migration("20200507094628_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .HasColumnName("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.CurrentStatus", b =>
                {
                    b.Property<int>("CurrentStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentStatusName")
                        .HasColumnName("CurrentStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("CurrentStatusId");

                    b.ToTable("CurrentStatuses");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.DocumentAttach", b =>
                {
                    b.Property<int>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentUrl")
                        .HasColumnName("DocumentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroceryKitId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DocumentId");

                    b.HasIndex("GroceryKitId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.FamilyMember", b =>
                {
                    b.Property<int>("FamilyMemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnName("Age")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("FamilyMemberStatusId")
                        .HasColumnType("int");

                    b.Property<int>("GroceryKitId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RelationId")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("FamilyMemberId");

                    b.HasIndex("FamilyMemberStatusId");

                    b.HasIndex("GroceryKitId");

                    b.HasIndex("RelationId");

                    b.ToTable("FamilyMembers");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.FamilyMemberStatus", b =>
                {
                    b.Property<int>("FamilyMemberStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("FamilyMemberStatusName")
                        .HasColumnName("FamilyMemberStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("FamilyMemberStatusId");

                    b.ToTable("FamilyMemberStatuses");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.GroceryKit", b =>
                {
                    b.Property<int>("GroceryKitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnName("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnName("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnName("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AuthorizedById")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("CurrentStatusId")
                        .HasColumnType("int");

                    b.Property<int>("DataCollectedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Donations")
                        .HasColumnName("Donations")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("FamilySize")
                        .HasColumnName("FamilySize")
                        .HasColumnType("int");

                    b.Property<string>("FatherOrHusbandName")
                        .HasColumnName("FatherOrHusbandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FoodCost")
                        .HasColumnName("FoodCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("FormNo")
                        .IsRequired()
                        .HasColumnName("FormNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnName("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("HouseRent")
                        .HasColumnName("HouseRent")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MedicalCost")
                        .HasColumnName("MedicalCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("MedicalProbId")
                        .HasColumnType("int");

                    b.Property<string>("MeritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OccupationId")
                        .HasColumnType("int");

                    b.Property<decimal>("OtherCost")
                        .HasColumnName("OtherCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("OtherIncome")
                        .HasColumnName("OtherIncome")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnName("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnName("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .HasColumnName("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidenceStatus")
                        .HasColumnName("ResidenceStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnName("Salary")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("SchoolCost")
                        .HasColumnName("SchoolCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ShortFallInCash")
                        .HasColumnName("ShortFallInCash")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("TotalCost")
                        .HasColumnName("TotalCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("TotalIncome")
                        .HasColumnName("TotalIncome")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("UtilitiesCost")
                        .HasColumnName("UtilitiesCost")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("ZakatAcceptable")
                        .HasColumnName("ZakatAcceptable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroceryKitId");

                    b.HasIndex("CityId");

                    b.HasIndex("CurrentStatusId");

                    b.HasIndex("MedicalProbId");

                    b.HasIndex("OccupationId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("GroceryKits");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.MedicalProb", b =>
                {
                    b.Property<int>("MedicalProbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MedicalProbName")
                        .HasColumnName("MedicalProbName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("MedicalProbId");

                    b.ToTable("MedicalProbs");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.Occupation", b =>
                {
                    b.Property<int>("OccupationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("OccupationName")
                        .HasColumnName("OccupationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("OccupationId");

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.OtherDocumentAttach", b =>
                {
                    b.Property<int>("OtherDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentName")
                        .HasColumnName("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentUrl")
                        .HasColumnName("DocumentUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroceryKitId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("OtherDocumentId");

                    b.HasIndex("GroceryKitId");

                    b.ToTable("OtherDocumentAttaches");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProvinceName")
                        .HasColumnName("ProvinceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.Relation", b =>
                {
                    b.Property<int>("RelationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnName("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnName("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnName("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnName("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("RelationName")
                        .HasColumnName("RelationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnName("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnName("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("RelationId");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.DocumentAttach", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.GroceryKit", "GroceryKit")
                        .WithMany("Documents")
                        .HasForeignKey("GroceryKitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.FamilyMember", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.FamilyMemberStatus", "FamilyMemberStatus")
                        .WithMany("FamilyMembers")
                        .HasForeignKey("FamilyMemberStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.GroceryKit", "GroceryKit")
                        .WithMany("FamilyMembers")
                        .HasForeignKey("GroceryKitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.Relation", "Relation")
                        .WithMany("FamilyMembers")
                        .HasForeignKey("RelationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.GroceryKit", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.City", "City")
                        .WithMany("GroceryKits")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.CurrentStatus", "CurrentStatus")
                        .WithMany("GroceryKits")
                        .HasForeignKey("CurrentStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.MedicalProb", "MedicalProb")
                        .WithMany("GroceryKits")
                        .HasForeignKey("MedicalProbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.Occupation", "Occupation")
                        .WithMany("GroceryKits")
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.Province", "Province")
                        .WithMany("GroceryKits")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.Master.OtherDocumentAttach", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.Master.GroceryKit", "GroceryKit")
                        .WithMany("OtherDocumentAttaches")
                        .HasForeignKey("GroceryKitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUserRole", b =>
                {
                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationRole", "ApplicationRole")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RWFOUNDATIONWebsite.DataModels.UserManagement.ApplicationUser", "ApplicationUser")
                        .WithMany("ApplicationUserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
