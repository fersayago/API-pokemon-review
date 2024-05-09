﻿namespace API_pokemon_review.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Owner> Owner { get; set; }
    }
}
