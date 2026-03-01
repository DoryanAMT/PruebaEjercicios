using PruebaEjercicios.Models;
using PruebaEjercicios.Repositories;

namespace PruebaEjercicios.Services
{
    public class HospitalServices
    {
        private HospitalRepository _repository;
        public HospitalServices(HospitalRepository repository)
        {
            this._repository = repository;
        }

        public async Task<List<Doctor>> GetDoctores()
        {
            return await _repository.GetDoctores();
        }
    }
}
