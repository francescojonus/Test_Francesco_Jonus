using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Benvenuto al test di prova di Francesco Jonus!";

            ViewBag.DatiDatabase = "<br><br>Dati seguenti letti...<br><br>";

            // using (SqlConnection conn = new SqlConnection("Database=Database1;Server=localhost\\SQL2008;Integrated Security=SSPI")) { using (SqlCommand cmd = new SqlCommand("select count(*) from DatiVari", conn)) { conn.Open(); ViewBag.DatiDatabase = "{0}"; cmd.ExecuteScalar()); } }

            // ViewBag.DatiDatabase = "";

            using (DataSet1 northwind = new DataSet1())
            {
                using (DataSet1TableAdapters.DatiVariTableAdapter ta = new DataSet1TableAdapters.DatiVariTableAdapter())
                {
                    ta.Fill(northwind.DatiVari); foreach (DataSet1.DatiVariRow row in northwind.DatiVari)
                    {
                        ViewBag.DatiDatabase = ViewBag.DatiDatabase + row.Nome + " " + row.Cognome + "<br>";
                    } 
                } 
            }

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
