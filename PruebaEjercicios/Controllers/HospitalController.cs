using Microsoft.AspNetCore.Mvc;
using PruebaEjercicios.Models;
using PruebaEjercicios.Services;
using System.Threading.Tasks;

namespace PruebaEjercicios.Controllers
{
    public class HospitalController : Controller
    {
        private HospitalServices _services;
        public HospitalController(HospitalServices services)
        {
            this._services = services; 
        }

        public async Task<IActionResult> Index
        (List<Doctor> doctores)
        {
            doctores = await _services.GetDoctores();
            return View(doctores);
        }
        //public async Task<IActionResult> Doctores
        //    (List<Doctor> doctores)
        //{
        //    doctores = await _services.GetDoctores();
        //    return View(doctores);
        //}
    }
}
