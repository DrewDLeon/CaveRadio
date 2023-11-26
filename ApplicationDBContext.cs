using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaveRadio.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CaveRadio
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Song> songs { get; set; }
    }
}