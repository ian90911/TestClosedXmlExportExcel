using ClosedXML.Excel;
using ClosedXML.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        CustomerRepository repo = new CustomerRepository();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetExcel()
        {
            using (var wb = GetExcelFile())
            {
                // Add ClosedXML.Extensions in your using declarations
                return wb.Deliver("generatedfile.xlsx");

            }
        }

        private XLWorkbook GetExcelFile()
        {
            return ClosedXmlHelper.ToClosedXmlExcel(repo.GetCustomers());
        }
    }
}