﻿namespace eTickets.Models
{
    public class Actor_Movie
    {

        public int Movie_ID { get; set; }
        public Movie Movie { get; set; }


        public int Actor_ID { get; set; }
        public Actor Actor { get; set; }
    }
}
