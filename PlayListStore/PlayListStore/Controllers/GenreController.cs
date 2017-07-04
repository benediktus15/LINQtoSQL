using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PlayListStore.Models;


namespace PlayListStore.Controllers
{
    public class GenreController : Controller
    {
        // from Model --> Operation.designer
        // hanya di gunakan disini (private)
        private OperationDataContext context = null;

        // 
        public GenreController()
        {
            context = new OperationDataContext();
        }

        public ActionResult Index()
        {
            // create the genreList variable
            List<GenreModel> genreList = new List<GenreModel>();

            // perform linq operation
            var query = from genre in context.Genres select genre;

            var genres = query.ToList();

            foreach (var a in genres)
            {
                genreList.Add(new GenreModel()
                {
                    Id = a.Id,
                    Name = a.Name
                });
            }

            return View(genreList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(GenreModel model)
        {
            try
            {
                Genre genre = new Genre()
                {
                    Name = model.Name
                };

                context.Genres.InsertOnSubmit(genre);
                context.SubmitChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }            
        }
    }
}