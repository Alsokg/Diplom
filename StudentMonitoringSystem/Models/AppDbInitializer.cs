using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentMonitoringSystem.Models
{
    public class AppDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            
            
            var role1 = new IdentityRole { Name = "Admin" };
            var role2 = new IdentityRole { Name = "Student" };
            var role3 = new IdentityRole { Name = "Lector" };
            
            roleManager.Create(role1);
            roleManager.Create(role2);
            roleManager.Create(role3);

            var stud = new ApplicationUser { Email = "qwert@gmail.com", UserName = "qwert@gmail.com", StydentBookNumber = "12121212" };
            string password = "123qweRT_";
            var result = userManager.Create(stud, password);
            var lector = new ApplicationUser { Email = "lector@gmail.com", UserName = "lector@gmail.com", isLector = true };
            
            var result2 = userManager.Create(lector, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(stud.Id, role2.Name);
            }
            if (result2.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(lector.Id, role3.Name);
            }
            
            base.Seed(context);
        }
    }
}
