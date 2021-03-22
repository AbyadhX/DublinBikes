using DublinBikes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DublinBikes.Data
{
    public class DublinBikesContext : DbContext
    {
        public DublinBikesContext(DbContextOptions<DublinBikesContext> options) : base(options)
        {
        }

        public DbSet<DublinBike> DublinBike { get; set; }
    }
}