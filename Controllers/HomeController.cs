using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReservationPlace.Models;

namespace ReservationPlace.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Affichage de tous les concerts ou bien recherche par lieu (id)
        public IActionResult ListeConcerts(string id)
        {
            using (Dal dal = new Dal())
            {
                List<Concert> Concerts = dal.ObtientTousLesConcerts(id);
                ViewBag.Concerts = Concerts;
            }

            return View();
        }

        public IActionResult AjouterConcert()
        {
            return View();
        }

        // Pour le moment, la page d'ajout manuel de concerts n'est pas fonctionnelle. Je fais alors appel à cette méthode lors de la validation du formulaire d'ajout de nouveau
        // concert (même avec les champs vides) pour rentrer ces données dans la base et avoir quelque chose à afficher.
        public IActionResult NouveauConcert()
        {
            using (Dal dal = new Dal())
            {
                dal.CreerConcert("Festival la foire aux vins", "Kendrick Lamar", new DateTime(2019, 9, 15, 20, 0, 0), "Colmar", "Parc d'exposition", 500);
                dal.CreerConcert("Tournée rock", "Scorpions", new DateTime(2019, 10, 3, 19, 30, 0), "Strasbourg", "Zénith", 200);
                dal.CreerConcert("Jazz manouche", "Théo Ceccaldi, Naissam Jalal et Osloob", new DateTime(2019, 11, 18, 19, 0, 0), "Sélestat", "Les Tanzmatten", 150);
                dal.CreerConcert("Tournée médiévale", "Laurent Voulzy", new DateTime(2019, 08, 20, 20, 30, 0), "Strasbourg", "Église St-Paul", 200);
                dal.CreerConcert("Cortéo", "Cirque du soleil", new DateTime(2019, 12, 12, 14, 0, 0), "Strasbourg", "Zénith", 20);
                dal.CreerConcert("Cortéo", "Cirque du soleil", new DateTime(2019, 12, 12, 20, 0, 0), "Strasbourg", "Zénith", 0);
                dal.CreerConcert("Tournée nationale", "Kery James", new DateTime(2019, 11, 28, 21, 0, 0), "Strasbourg", "La Laiterie", 122);
            }

            return View();
        }
    }
}
