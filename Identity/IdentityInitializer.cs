using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Abc.MvcWebUI.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Abc.MvcWebUI.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {

        protected override void Seed(IdentityDataContext context)
        {


            
            if(!context.Roles.Any(i => i.Name =="admin")) //admin adında bir rol yoksa
            {


                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name ="admin",Description="admin rolü" };
                
                manager.Create(role);
            
            
            }

            if (!context.Roles.Any(i => i.Name == "user")) //user adında bir rol yoksa
            {


                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole(){ Name = "user", Description = "user rolü" };

                manager.Create(role);


            }


            if (!context.Users.Any(i => i.Name == "ketemizceri"))
            {


                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user= new ApplicationUser() { Name ="Kıvanç Efe",Surname="Temizçeri",UserName="ketemizceri",Email="ketemizceri@hotmail.com"};

                manager.Create(user, "1234567");
                //Burada Kullanıcı hem admin hem user
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");


            }



            if (!context.Users.Any(i => i.Name == "zafergumussu"))
            {


                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "Zafer", Surname = "Gümüşsu", UserName = "zafergumussu", Email = "zafergumussu@hotmail.com" };

                manager.Create(user, "1234567");
                manager.AddToRole(user.Id, "user");


            }


            base.Seed(context);
        }



    }
}