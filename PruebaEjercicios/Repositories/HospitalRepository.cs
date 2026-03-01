using Microsoft.EntityFrameworkCore;
using PruebaEjercicios.Models;

namespace PruebaEjercicios.Repositories
{
    public class HospitalRepository
    {
        private HospitalContext _context;
        public HospitalRepository(HospitalContext context)
        {
            this._context = context;
        }

        public async Task<List<Doctor>> GetDoctores()
        {
            return await _context.Doctors.ToListAsync();
        }
    }
}
