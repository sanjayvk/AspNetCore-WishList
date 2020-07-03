using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDBContext:DbContext
    {
        
        public ApplicationDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Item> items { get; set; }
    }
}
