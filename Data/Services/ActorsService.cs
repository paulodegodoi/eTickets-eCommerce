using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _context.Actors.ToListAsync();   
        }
        public async Task<Actor> GetByIdAsync(int id)
        {
            return await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(int id)
        {
            var actorToRemove = await GetByIdAsync(id);
            _context.Actors.Remove(actorToRemove);
            await _context.SaveChangesAsync();
        }

        public async Task<Actor> UpdateAsync(int id, Actor actorUpdated)
        {
            _context.Actors.Update(actorUpdated);
            await _context.SaveChangesAsync();
            return actorUpdated;
        }
    }
}
