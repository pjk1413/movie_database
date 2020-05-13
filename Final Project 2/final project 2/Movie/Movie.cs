using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2
{
    public class Movie
    {
        public int movie_number { get; set; }
        public string movie_title { get; set; }
        public string Description { get; set; }
        public int movie_year_made { get; set; }
        public int genre_id { get; set; }
        public string movie_rating { get; set; }
        public string media_type { get; set; }
        public decimal movie_retail_cost { get; set; }
        public decimal movie_rental_cost { get; set; }
        public int copies_on_hand { get; set; }
        public string image { get; set; }
        public string trailer { get; set; }

    }
}
