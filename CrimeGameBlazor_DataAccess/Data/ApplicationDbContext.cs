using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeGameBlazor_DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
        public DbSet<Gangster> Gangsters => Set<Gangster>();
        public DbSet<PersonalMessage> PersonalMessages => Set<PersonalMessage>();
        public DbSet<Gang> Gangs => Set<Gang>();
        public DbSet<GetAwayCar> GetAwayCars => Set<GetAwayCar>();
        public DbSet<BulletFactory> BulletFactories => Set<BulletFactory>();
        public DbSet<XTCFactory> XTCFactories => Set<XTCFactory>();
        public DbSet<CocaineFactory> CocaineFactories => Set<CocaineFactory>();
        public DbSet<CannabisPlantation> CannabisPlantations => Set<CannabisPlantation>();
        public DbSet<Casino> Casinos => Set<Casino>();
        public DbSet<Prison> Prison => Set<Prison>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relations
            modelBuilder.Entity<Gang>()
                .HasMany(gang => gang.Members)
                .WithOne(gangster => gangster.Gang)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Gangster>()
                .HasOne(gangster => gangster.User)
                .WithOne(user => user.CurrentGangster)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Gangster>()
                .HasMany(gangster => gangster.GetAwayCars)
                .WithOne(cars => cars.Owner);

            modelBuilder.Entity<Gang>()
                .HasOne(gang => gang.Owner)
                .WithOne(gangster => gangster.OwnGang)
                .HasForeignKey<Gangster>(g => g.OwnGangId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Gangster>()
                .HasOne(g => g.Casino)
                .WithOne(c => c.Owner)
                .HasForeignKey<Casino>(c => c.OwnerId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Gangster>()
                .HasOne(g => g.Factory)
                .WithOne(f => f.Owner)
                .HasForeignKey<Factory>(f => f.OwnerId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Gangster>()
                .HasMany(g => g.ReceivedMessages)
                .WithOne(m => m.Reciever)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Gangster>()
                .HasMany(g => g.SentMessages)
                .WithOne(m => m.Sender)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Cars)
                .WithOne(c => c.CurrentCity)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Gangs)
                .WithOne(c => c.City)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Gangsters)
                .WithOne(c => c.CurrentCity)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasMany(c => c.Factorys)
                .WithOne(c => c.City)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<City>()
                .HasOne(c => c.Casino)
                .WithOne(c => c.City)
                .HasForeignKey<Casino>(c => c.CityId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Prison>()
                .HasMany(p => p.Gangsters)
                .WithOne(g => g.Prison)
                .OnDelete(DeleteBehavior.NoAction);
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
