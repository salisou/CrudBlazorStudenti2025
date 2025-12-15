using BlazorApp1.Data;
using BlazorApp1.Models;
using BlazorApp1.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Services.Repositories
{
    public class StudentiService : IStudentiService
    {
        private readonly WebAppContext _context;

        public StudentiService(WebAppContext context)
        {
            _context = context;
        }

        public async Task AddStudenteAsync(Studente studente)
        {
            await _context.Studenti.AddAsync(studente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudenteAsync(int id)
        {
            Studente? studente = await _context.Studenti.FindAsync(id);
            if (studente != null)
            {
                _context.Studenti.Remove(studente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Studente>> GetAllStudentiAsync() => await _context.Studenti.ToListAsync();

        public async Task<Studente?> GetStudenteByIdAsync(int id) => await _context.Studenti.FirstOrDefaultAsync(s => s.Id == id);

        // Esercizio per domani: implementare UpdateStudenteAsync
        public Task UpdateStudenteAsync(Studente studente)
        {
            throw new NotImplementedException();
        }
    }
}
