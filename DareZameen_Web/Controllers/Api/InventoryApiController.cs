using DareZameen_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DareZameen_Web.Controllers.Api
{
    public class InventoryApiController : ApiController
    {
        // GET api/<controller>
        private RealStateDataEntities db = new RealStateDataEntities();
        private static List<string> Customers = new List<string> { "Hummam", "Umer", "Ashok" };
        [HttpGet]
        public IEnumerable<string> GetName()
        {
            var Cust = new List<string>();
            var DbCust = db.Customer.Take(15).ToList();
            foreach (var c in DbCust)
            {
                Cust.Add(c.Name);
            }
            return Cust;
        }
       
    }
}