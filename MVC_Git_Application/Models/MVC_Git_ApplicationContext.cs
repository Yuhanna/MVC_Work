using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Git_Application.Models
{
    public class MVC_Git_ApplicationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_Git_ApplicationContext() : base("name=MVC_Git_ApplicationContext")
        {
            Database.SetInitializer(new GitInitializer());
        }

        public System.Data.Entity.DbSet<MVC_Git_Application.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<MVC_Git_Application.Models.Product> Products { get; set; }
    }
}
