using PAP.Business;
using System.Web.Mvc;

namespace PAP.Mvc.Controllers
{
    public class LibraryController : Controller
    {
        private readonly BookManager _bookManager;

        public LibraryController()
        {
            _bookManager = new BookManager();
        }

        public ActionResult Index()
        {

            
            //_bookManager.MigrateOldBooksToDatabase();

            
            var books = _bookManager.GetAllBooksFromDataModel();
            return View(books);


        }
    }
}