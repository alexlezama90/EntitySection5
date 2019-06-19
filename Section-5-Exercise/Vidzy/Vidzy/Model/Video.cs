using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy.Model
{
    public class Video
    {
        //public Video()
        //{
        //    Genres = new HashSet<Genre>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }

        //public ICollection<Genre> Genres { get; set; }
        public byte GenreId { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }

        public ICollection<Tag> Tags { get; set; }

        public Video()
        {
            this.Tags = new HashSet<Tag>();
        }
    }
}
