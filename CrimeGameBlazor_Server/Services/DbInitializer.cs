using CrimeGameBlazor_DataAccess.Data;
using CrimeGameBlazor_Server.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CrimeGameBlazor_Server.Services
{
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
                if (!_roleManager.RoleExistsAsync("Player").GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole("Player")).GetAwaiter().GetResult();
                    _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
                }
                else
                {
                    return;
                }

                IdentityUser user = new()
                {
                    UserName = "admin@admin.com",
                    Email = "admin@admin.com",
                    EmailConfirmed = true
                };

                _userManager.CreateAsync(user, "Admin123!").GetAwaiter().GetResult();

                _userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
