using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andycabar.Controllers
{

    [Gordibute]
    public class TransactionsController : Controller
    {
        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Print(string Phone, string Date)
        {
            return View();
        }
    }
}