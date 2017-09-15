using Andycabar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Andycabar.Controllers
{


    public class TransfersController : Controller
    {
        // GET: Transactions
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Phone, string Date)
        {
            return RedirectToAction("Print", new { Phone = Phone, Date = Date });
        }
        /// <summary>
        /// Prints the QR barcodes
        /// </summary>
        /// <param name="Phone"></param>
        /// <param name="Date"></param>
        /// <returns></returns>
        public ActionResult Print(string Phone, string Date)
        {

            MainModel db = new MainModel();

            DateTime d = Convert.ToDateTime(Date);

            var query = (

                from transfer in db.ProductTransfers

                join product in db.Products
                on transfer.ProductId equals product.Id

                join groupp in db.Groups
                on product.GroupId equals groupp.Id

                join store in db.Stores
                on transfer.StoreId equals store.Id

                join seller in db.Sellers
                on store.Id equals seller.StoreId

                join user in db.Users
                on seller.UserId equals user.Id

                select new { transfer, product, store, seller, user, groupp }
                )
                .Where(x => x.user.Mobile == Phone)
                .ToList()
                .Where(x => x.transfer.SubmitEvent.ToString("yyyy-MM-dd") == d.ToString("yyyy-MM-dd"))
                .ToList();

            return PartialView(query.Select(x =>
                new Tuple<string, string, string, string>(x.transfer.Barcode, x.product.DetailedName, x.store.Name, x.groupp.Name)
        ));
        }
    }
}