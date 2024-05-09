namespace API_pokemon_review.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int PokedexId {  get; set; }
        public bool Shiny { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
