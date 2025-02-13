using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoSitios.Entities;
using ProyectoSitios.Services.Abstract;

namespace ProyectoSitios.Pages.Bitacoras
{
    public class IndexModel : PageModel
    {
        private readonly IBitacoraService _bitacoraService;

        public IndexModel (IBitacoraService bitacoraService)
        {
            _bitacoraService = bitacoraService;
            Bitacoras = new List<Bitacora>();
        }
        public IEnumerable<Bitacora> Bitacoras { get; set; }
     
        public async Task OnGetAsync()
        {
            Bitacoras = await _bitacoraService.GetAllAsync();
        }
    }
}
