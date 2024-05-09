namespace API_pokemon_review.Models
{
    public class PokemonPoketype
    {
        public int PokemonId { get; set; }
        public int PokeTypeId { get; set; }
        public Pokemon Pokemon { get; set; }
        public PokeType PokeType { get; set; }
    }
}
