using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
      public class MoviesAppContext : DbContext
        {

            public DbSet<Movie> Movies { get; set; }

        }
    
}
