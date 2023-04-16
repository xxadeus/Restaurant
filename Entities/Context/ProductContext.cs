using Entities.Items;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Context
{
    public class ProductContext : IdentityDbContext<User>
    {
        public ProductContext()
        {

        }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set;}
        public virtual DbSet<ProductCategory> ProductCategories { get; set;}
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
