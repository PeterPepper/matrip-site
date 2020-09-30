﻿// <auto-generated />
using System;
using Matrip.Web.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Matrip.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma01user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ma01Iduser");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnName("ma01AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ma01ConcurrencyStamp");

                    b.Property<string>("Email")
                        .HasColumnName("ma01Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnName("ma01EmailConfirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnName("ma01LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnName("ma01LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnName("ma01NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnName("ma01NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnName("ma01PasswordHash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("ma01phone");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnName("ma01PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp")
                        .HasColumnName("ma01SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnName("ma01TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasColumnName("ma01UserName")
                        .HasMaxLength(256);

                    b.Property<string>("ma01FullName")
                        .IsRequired();

                    b.Property<DateTime>("ma01birth");

                    b.Property<string>("ma01type");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("ma01user");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma02profile", b =>
                {
                    b.Property<int>("ma02idprofile")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK0201iduser");

                    b.Property<int>("FK0206idtripcategory");

                    b.HasKey("ma02idprofile");

                    b.HasIndex("FK0201iduser");

                    b.HasIndex("FK0206idtripcategory");

                    b.ToTable("ma02profile");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma03language", b =>
                {
                    b.Property<int>("ma03idlanguage")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ma03name")
                        .IsRequired();

                    b.HasKey("ma03idlanguage");

                    b.ToTable("ma03language");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma04guide", b =>
                {
                    b.Property<int>("ma04idguide")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK0401iduser");

                    b.Property<string>("ma04MEI")
                        .IsRequired();

                    b.HasKey("ma04idguide");

                    b.HasIndex("FK0401iduser")
                        .IsUnique();

                    b.ToTable("ma04guide");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma05trip", b =>
                {
                    b.Property<int>("ma05idtrip")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK0504idguide");

                    b.Property<int>("FK0506idtripcategory");

                    b.Property<int>("FK0509idcity");

                    b.Property<string>("ma05accompanyingchild");

                    b.Property<TimeSpan>("ma05duration");

                    b.Property<TimeSpan>("ma05entry");

                    b.Property<TimeSpan>("ma05exit");

                    b.Property<double?>("ma05maxweight");

                    b.Property<int>("ma05minimunage");

                    b.Property<double?>("ma05minweight");

                    b.Property<string>("ma05name")
                        .IsRequired();

                    b.Property<string>("ma05transfer");

                    b.HasKey("ma05idtrip");

                    b.HasIndex("FK0504idguide");

                    b.HasIndex("FK0506idtripcategory");

                    b.HasIndex("FK0509idcity");

                    b.ToTable("ma05trip");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma06tripcategory", b =>
                {
                    b.Property<int>("ma06idtripcategory")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ma06name")
                        .IsRequired();

                    b.HasKey("ma06idtripcategory");

                    b.ToTable("ma06tripcategory");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma07country", b =>
                {
                    b.Property<int>("ma07idcountry")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ma07name")
                        .IsRequired();

                    b.HasKey("ma07idcountry");

                    b.ToTable("ma07country");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma08uf", b =>
                {
                    b.Property<int>("ma08iduf")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK0807idcountry");

                    b.Property<string>("ma08name")
                        .IsRequired();

                    b.HasKey("ma08iduf");

                    b.HasIndex("FK0807idcountry");

                    b.ToTable("ma08uf");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma09city", b =>
                {
                    b.Property<int>("ma09idcity")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK0908iduf");

                    b.Property<string>("ma09name")
                        .IsRequired();

                    b.HasKey("ma09idcity");

                    b.HasIndex("FK0908iduf");

                    b.ToTable("ma09city");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma10userlanguages", b =>
                {
                    b.Property<int>("ma10iduserlanguages")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK1001iduser");

                    b.Property<int>("FK1003idlanguage");

                    b.HasKey("ma10iduserlanguages");

                    b.HasIndex("FK1001iduser");

                    b.HasIndex("FK1003idlanguage");

                    b.ToTable("ma10userlanguages");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma11service", b =>
                {
                    b.Property<int>("ma11idservice")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FK1105idtrip");

                    b.Property<string>("ma11description")
                        .IsRequired();

                    b.Property<string>("ma11name")
                        .IsRequired();

                    b.Property<string>("ma11restriction");

                    b.HasKey("ma11idservice");

                    b.HasIndex("FK1105idtrip");

                    b.ToTable("ma11service");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma02profile", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user", "ma01user")
                        .WithMany("ma02profile")
                        .HasForeignKey("FK0201iduser")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma06tripcategory", "ma06tripcategory")
                        .WithMany("ma02profile")
                        .HasForeignKey("FK0206idtripcategory")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma04guide", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user", "ma01user")
                        .WithOne("ma04guide")
                        .HasForeignKey("Matrip.Web.Domain.Models.Entities.ma04guide", "FK0401iduser")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma05trip", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma04guide", "ma04guide")
                        .WithMany("ma05trip")
                        .HasForeignKey("FK0504idguide")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma06tripcategory", "ma06tripcategory")
                        .WithMany("ma05trip")
                        .HasForeignKey("FK0506idtripcategory")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma09city", "ma09city")
                        .WithMany("ma05trip")
                        .HasForeignKey("FK0509idcity")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma08uf", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma07country", "ma07country")
                        .WithMany("ma08uf")
                        .HasForeignKey("FK0807idcountry")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma09city", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma08uf", "ma08uf")
                        .WithMany("ma09city")
                        .HasForeignKey("FK0908iduf")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma10userlanguages", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user", "ma01user")
                        .WithMany("ma10userlanguages")
                        .HasForeignKey("FK1001iduser")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma03language", "ma03language")
                        .WithMany("ma10userlanguages")
                        .HasForeignKey("FK1003idlanguage")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Matrip.Web.Domain.Models.Entities.ma11service", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma05trip", "ma05trip")
                        .WithMany("ma11service")
                        .HasForeignKey("FK1105idtrip")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Matrip.Web.Domain.Models.Entities.ma01user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
