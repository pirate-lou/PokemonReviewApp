﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Interface;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;

        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        // ICollection can't be edited and it can only be shown only be read 
        // it's fancy List<>
        public ICollection<Pokemon> GetPokemons()
        {
            // in there we just putting database calls
            return _context.Pokemon.OrderBy(p => p.Id).ToList();
        }

        // if u'll see the folder called "Services" - it's chunk of code that are being pulled out 
        // but they're being pulled out and being used and they're not database calls 
    }
}
