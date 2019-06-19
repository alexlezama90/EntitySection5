using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.EntityConfigurations;
using Vidzy.Model;

namespace Vidzy
{
    public class VidzyContext : DbContext
    {
        public VidzyContext()
            :base("name=VidzyContext")
        {
        }

        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
