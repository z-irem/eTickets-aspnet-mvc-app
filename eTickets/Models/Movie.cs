using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }

        //  enum (numaralandırma), belirli değerler kümesini temsil etmek için kullanılan bir türdür
        public MovieCategory MovieCategory { get; set; }



        // relationships
        public List<Actor_Movie> Actor_Movies { get; set; }



        // cinema
        public int Cinema_id { get; set; }
        
        [ForeignKey("Cinema_id")]        
        public Cinema Cinema { get; set; }


        // producer
        public int Producer_id { get; set; }

        [ForeignKey("Producer_id")]
        public Producer Producer { get; set; }


    }
}
