using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Practice_7.Models
{
    public class GuestsContext : DbContext
    { 
        public DbSet<Guests> Guests { get; set; }
    }
}