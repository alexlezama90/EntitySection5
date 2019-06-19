using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.Model;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContetxt = new VidzyContext();

            //Video video = new Video
            //{
            //    Name = "Die Hard 3",
            //    Classification = Classification.Silver,
            //    Genre = dbContetxt.Genres.FirstOrDefault(g => g.Name == "Action"),
            //    ReleaseDate = DateTime.Now
            //};

            //dbContetxt.Videos.Add(video);
            //dbContetxt.SaveChanges();

            foreach ( var v in dbContetxt.Videos)
            {
                Console.WriteLine($"{v.Name} {v.Genre.Name} {v.Classification}");
            }

            Console.ReadLine();
        }
    }
}
