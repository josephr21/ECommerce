using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using prenota5H.Models;


namespace Ecommerce.Controllers
{
    public class MaglieController : Controller
    {
        // Simulazione di un elenco di maglie
        private List<Maglia> maglie = new List<Maglia>
        {
            new Maglia { Id = 1, Squadra = "Juventus", Taglia = "M", Prezzo = 50 },
            new Maglia { Id = 2, Squadra = "Barcellona", Taglia = "L", Prezzo = 55 },
            // Aggiungi altre maglie
        };

        public ActionResult Index()
        {
            return View(maglie);
        }

        // Altri metodi del controller per aggiungere, rimuovere, modificare maglie, gestire il carrello, ecc.
    
}

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


    public IActionResult Privacy()
    {
        return View();
    }

    
    public IActionResult Prenota()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Prenotato(Utente u)
    {
        Database db = new ();
        db.Utenti.Add( u );
        db.SaveChanges();
        return View( db );
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}
