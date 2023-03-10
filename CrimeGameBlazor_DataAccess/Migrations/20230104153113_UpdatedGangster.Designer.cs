// <auto-generated />
using System;
using CrimeGameBlazor_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CrimeGameBlazor_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230104153113_UpdatedGangster")]
    partial class UpdatedGangster
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Casino", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId")
                        .IsUnique();

                    b.HasIndex("OwnerId")
                        .IsUnique()
                        .HasFilter("[OwnerId] IS NOT NULL");

                    b.ToTable("Casinos");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Factory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsProducing")
                        .HasColumnType("bit");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId")
                        .IsUnique()
                        .HasFilter("[OwnerId] IS NOT NULL");

                    b.ToTable("Factory");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Factory");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gang", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Gangs");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gangster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AmountOfBullets")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfMoneyInBank")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfMoneyInPocket")
                        .HasColumnType("int");

                    b.Property<double>("BreakoutSkill")
                        .HasColumnType("float");

                    b.Property<int?>("BuyOutAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CurrentCityId")
                        .HasColumnType("int");

                    b.Property<double>("DrivingSkill")
                        .HasColumnType("float");

                    b.Property<int?>("GangId")
                        .HasColumnType("int");

                    b.Property<int>("HP")
                        .HasColumnType("int");

                    b.Property<DateTime>("InPrisonUntill")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAlive")
                        .HasColumnType("bit");

                    b.Property<int?>("MeansOfTransportation")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NextBasicCrimeAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OwnGangId")
                        .HasColumnType("int");

                    b.Property<int?>("PrisonId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<double>("RankProgression")
                        .HasColumnType("float");

                    b.Property<double>("ShootingSkill")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Weapon")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CurrentCityId");

                    b.HasIndex("GangId");

                    b.HasIndex("OwnGangId")
                        .IsUnique()
                        .HasFilter("[OwnGangId] IS NOT NULL");

                    b.HasIndex("PrisonId");

                    b.HasIndex("UserId");

                    b.ToTable("Gangsters");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.GetAwayCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CityId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("Intact")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("OwnerId");

                    b.ToTable("GetAwayCars");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.PersonalMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MessageContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Read")
                        .HasColumnType("bit");

                    b.Property<int>("RecieverId")
                        .HasColumnType("int");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecieverId");

                    b.HasIndex("SenderId");

                    b.ToTable("PersonalMessages");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Prison", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BreakoutCount")
                        .HasColumnType("int");

                    b.Property<int>("PrisonRegister")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prison");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("GangsterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("GangsterId");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.BulletFactory", b =>
                {
                    b.HasBaseType("CrimeGameBlazor_DataAccess.Factory");

                    b.Property<int>("AmountOfBullets")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("BulletFactory");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.CannabisPlantation", b =>
                {
                    b.HasBaseType("CrimeGameBlazor_DataAccess.Factory");

                    b.Property<int>("AmountOfKilos")
                        .HasColumnType("int")
                        .HasColumnName("CannabisPlantation_AmountOfKilos");

                    b.HasDiscriminator().HasValue("CannabisPlantation");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.CocaineFactory", b =>
                {
                    b.HasBaseType("CrimeGameBlazor_DataAccess.Factory");

                    b.Property<int>("AmountOfKilos")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("CocaineFactory");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.XTCFactory", b =>
                {
                    b.HasBaseType("CrimeGameBlazor_DataAccess.Factory");

                    b.Property<int>("AmountOfKilos")
                        .HasColumnType("int")
                        .HasColumnName("XTCFactory_AmountOfKilos");

                    b.HasDiscriminator().HasValue("XTCFactory");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Casino", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.City", "City")
                        .WithOne("Casino")
                        .HasForeignKey("CrimeGameBlazor_DataAccess.Casino", "CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "Owner")
                        .WithOne("Casino")
                        .HasForeignKey("CrimeGameBlazor_DataAccess.Casino", "OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("City");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Factory", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.City", "City")
                        .WithMany("Factorys")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "Owner")
                        .WithOne("Factory")
                        .HasForeignKey("CrimeGameBlazor_DataAccess.Factory", "OwnerId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("City");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gang", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.City", "City")
                        .WithMany("Gangs")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gangster", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.City", "CurrentCity")
                        .WithMany("Gangsters")
                        .HasForeignKey("CurrentCityId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CrimeGameBlazor_DataAccess.Gang", "Gang")
                        .WithMany("Members")
                        .HasForeignKey("GangId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("CrimeGameBlazor_DataAccess.Gang", "OwnGang")
                        .WithOne("Owner")
                        .HasForeignKey("CrimeGameBlazor_DataAccess.Gangster", "OwnGangId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CrimeGameBlazor_DataAccess.Prison", "Prison")
                        .WithMany("Gangsters")
                        .HasForeignKey("PrisonId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("CrimeGameBlazor_DataAccess.ApplicationUser", "User")
                        .WithMany("Gangsters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CurrentCity");

                    b.Navigation("Gang");

                    b.Navigation("OwnGang");

                    b.Navigation("Prison");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.GetAwayCar", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.City", "CurrentCity")
                        .WithMany("Cars")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "Owner")
                        .WithMany("GetAwayCars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentCity");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.PersonalMessage", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "Reciever")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("RecieverId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Reciever");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.ApplicationUser", b =>
                {
                    b.HasOne("CrimeGameBlazor_DataAccess.Gangster", "CurrentGangster")
                        .WithMany()
                        .HasForeignKey("GangsterId");

                    b.Navigation("CurrentGangster");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.City", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Casino")
                        .IsRequired();

                    b.Navigation("Factorys");

                    b.Navigation("Gangs");

                    b.Navigation("Gangsters");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gang", b =>
                {
                    b.Navigation("Members");

                    b.Navigation("Owner")
                        .IsRequired();
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Gangster", b =>
                {
                    b.Navigation("Casino");

                    b.Navigation("Factory");

                    b.Navigation("GetAwayCars");

                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.Prison", b =>
                {
                    b.Navigation("Gangsters");
                });

            modelBuilder.Entity("CrimeGameBlazor_DataAccess.ApplicationUser", b =>
                {
                    b.Navigation("Gangsters");
                });
#pragma warning restore 612, 618
        }
    }
}
