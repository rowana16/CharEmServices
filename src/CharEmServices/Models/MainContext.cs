using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharEmServices.Models
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }
        public DbSet<ServiceRecipient> ServiceRecipient {get;set;}
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        public DbSet<LinkServiceProvideLocation> LinkServiceProvideLocation { get; set; }
        public DbSet<LinkServiceProvideService> LinkServiceProvideService { get; set; }
        public DbSet<LinkServiceProvideUser> LinkServiceProvideUser { get; set; }
                
        public DbSet<LinkServiceRecipLocation> LinkServiceRecipLocation { get; set; }
        public DbSet<LinkServiceRecipService> LinkServiceRecipService { get; set; }
        public DbSet<LinkServiceRecipUser> LinkServiceRecipUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LinkServiceProvideLocation>().HasKey(x => new { x.ServiceProviderId, x.LocationId });
            modelBuilder.Entity<LinkServiceProvideService>().HasKey(x => new { x.ServiceProviderId, x.ServiceId });
            modelBuilder.Entity<LinkServiceProvideUser>().HasKey(x => new { x.ServiceProviderId, x.UserId });
            
            modelBuilder.Entity<LinkServiceProvideLocation>()
                .HasOne(x => x.ServiceProvider)
                .WithMany(x => x.LinkLocations)
                .HasForeignKey(x => x.ServiceProviderId);

            modelBuilder.Entity<LinkServiceProvideLocation>()
                .HasOne(x => x.Location)
                .WithMany(x => x.LinkServiceProviders)
                .HasForeignKey(x => x.LocationId);

            modelBuilder.Entity<LinkServiceProvideService>()
                .HasOne(x => x.ServiceProvider)
                .WithMany(x => x.LinkServices)
                .HasForeignKey(x => x.ServiceProviderId);

            modelBuilder.Entity<LinkServiceProvideService>()
                .HasOne(x => x.Service)
                .WithMany(x => x.LinkServiceProviders)
                .HasForeignKey(x => x.ServiceId);

            modelBuilder.Entity<LinkServiceProvideUser>()
               .HasOne(x => x.ServiceProvider)
               .WithMany(x => x.LinkUsers)
               .HasForeignKey(x => x.ServiceProviderId);

            modelBuilder.Entity<LinkServiceProvideUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.LinkServiceProviders)
                .HasForeignKey(x => x.UserId);

            modelBuilder.Entity<LinkServiceRecipLocation>().HasKey(x => new { x.ServiceRecipientId, x.LocationId });
            modelBuilder.Entity<LinkServiceRecipService>().HasKey(x => new { x.ServiceRecipientId, x.ServiceId });
            modelBuilder.Entity<LinkServiceRecipUser>().HasKey(x => new { x.ServiceRecipientId, x.UserId });

            modelBuilder.Entity<LinkServiceRecipLocation>()
                .HasOne(x => x.ServiceRecipient)
                .WithMany(x => x.LinkLocations)
                .HasForeignKey(x => x.ServiceRecipientId);

            modelBuilder.Entity<LinkServiceRecipLocation>()
                .HasOne(x => x.Location)
                .WithMany(x => x.LinkServiceRecipients)
                .HasForeignKey(x => x.LocationId);

            modelBuilder.Entity<LinkServiceRecipService>()
                .HasOne(x => x.ServiceRecipient)
                .WithMany(x => x.LinkServices)
                .HasForeignKey(x => x.ServiceRecipientId);

            modelBuilder.Entity<LinkServiceRecipService>()
                .HasOne(x => x.Service)
                .WithMany(x => x.LinkServiceRecipients)
                .HasForeignKey(x => x.ServiceId);

            modelBuilder.Entity<LinkServiceRecipUser>()
               .HasOne(x => x.ServiceRecipient)
               .WithMany(x => x.LinkUsers)
               .HasForeignKey(x => x.ServiceRecipientId);

            modelBuilder.Entity<LinkServiceRecipUser>()
                .HasOne(x => x.User)
                .WithMany(x => x.LinkServiceRecipients)
                .HasForeignKey(x => x.UserId);

        }

    }
}
