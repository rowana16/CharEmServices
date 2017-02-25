using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CharEmServices.Models;

namespace CharEmServices.Migrations
{
    [DbContext(typeof(MainContext))]
    partial class MainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CharEmServices.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("Zip");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CharEmServices.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("AddressId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TeamId");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideLocation", b =>
                {
                    b.Property<int>("ServiceProviderId");

                    b.Property<int>("LocationId");

                    b.HasKey("ServiceProviderId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LinkServiceProvideLocation");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideService", b =>
                {
                    b.Property<int>("ServiceProviderId");

                    b.Property<int>("ServiceId");

                    b.HasKey("ServiceProviderId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("LinkServiceProvideService");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideUser", b =>
                {
                    b.Property<int>("ServiceProviderId");

                    b.Property<string>("UserId");

                    b.HasKey("ServiceProviderId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LinkServiceProvideUser");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipLocation", b =>
                {
                    b.Property<int>("ServiceRecipientId");

                    b.Property<int>("LocationId");

                    b.HasKey("ServiceRecipientId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("LinkServiceRecipLocation");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipService", b =>
                {
                    b.Property<int>("ServiceRecipientId");

                    b.Property<int>("ServiceId");

                    b.HasKey("ServiceRecipientId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("LinkServiceRecipService");
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipUser", b =>
                {
                    b.Property<int>("ServiceRecipientId");

                    b.Property<string>("UserId");

                    b.HasKey("ServiceRecipientId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("LinkServiceRecipUser");
                });

            modelBuilder.Entity("CharEmServices.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LocationDescription");

                    b.Property<string>("LocationName");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("CharEmServices.Models.OrganizationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TypeDescription");

                    b.Property<string>("TypeName");

                    b.HasKey("Id");

                    b.ToTable("OrganizationTypes");
                });

            modelBuilder.Entity("CharEmServices.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ServiceDetails");

                    b.Property<string>("ServiceName");

                    b.Property<int>("ServiceTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CharEmServices.Models.ServiceProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("OrganizationName");

                    b.Property<int>("OrganizationTypeId");

                    b.Property<int>("TeamId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrganizationTypeId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceProviders");
                });

            modelBuilder.Entity("CharEmServices.Models.ServiceRecipient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<string>("OrganizationName");

                    b.Property<int>("OrganizationTypeId");

                    b.Property<int>("TeamId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("OrganizationTypeId");

                    b.HasIndex("TeamId");

                    b.HasIndex("UserId");

                    b.ToTable("ServiceRecipient");
                });

            modelBuilder.Entity("CharEmServices.Models.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("name");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("CharEmServices.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("CharEmServices.Models.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CharEmServices.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CharEmServices.Models.AppUser", b =>
                {
                    b.HasOne("CharEmServices.Models.Address", "Address")
                        .WithMany("Users")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.UserType", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideLocation", b =>
                {
                    b.HasOne("CharEmServices.Models.Location", "Location")
                        .WithMany("LinkServiceProviders")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.ServiceProvider", "ServiceProvider")
                        .WithMany("LinkLocations")
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideService", b =>
                {
                    b.HasOne("CharEmServices.Models.Service", "Service")
                        .WithMany("LinkServiceProviders")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.ServiceProvider", "ServiceProvider")
                        .WithMany("LinkServices")
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceProvideUser", b =>
                {
                    b.HasOne("CharEmServices.Models.ServiceProvider", "ServiceProvider")
                        .WithMany("LinkUsers")
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.AppUser", "User")
                        .WithMany("LinkServiceProviders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipLocation", b =>
                {
                    b.HasOne("CharEmServices.Models.Location", "Location")
                        .WithMany("LinkServiceRecipients")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.ServiceRecipient", "ServiceRecipient")
                        .WithMany("LinkLocations")
                        .HasForeignKey("ServiceRecipientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipService", b =>
                {
                    b.HasOne("CharEmServices.Models.Service", "Service")
                        .WithMany("LinkServiceRecipients")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.ServiceRecipient", "ServiceRecipient")
                        .WithMany("LinkServices")
                        .HasForeignKey("ServiceRecipientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.LinkServiceRecipUser", b =>
                {
                    b.HasOne("CharEmServices.Models.ServiceRecipient", "ServiceRecipient")
                        .WithMany("LinkUsers")
                        .HasForeignKey("ServiceRecipientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.AppUser", "User")
                        .WithMany("LinkServiceRecipients")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.Service", b =>
                {
                    b.HasOne("CharEmServices.Models.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CharEmServices.Models.ServiceProvider", b =>
                {
                    b.HasOne("CharEmServices.Models.Address", "Address")
                        .WithMany("ServiceProviders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.OrganizationType", "OrganizationType")
                        .WithMany("ServiceProviders")
                        .HasForeignKey("OrganizationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CharEmServices.Models.ServiceRecipient", b =>
                {
                    b.HasOne("CharEmServices.Models.Address", "Address")
                        .WithMany("ServiceRecipients")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.OrganizationType", "OrganizationType")
                        .WithMany("ServiceRecipients")
                        .HasForeignKey("OrganizationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("CharEmServices.Models.UserRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CharEmServices.Models.AppUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CharEmServices.Models.AppUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("CharEmServices.Models.UserRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CharEmServices.Models.AppUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
