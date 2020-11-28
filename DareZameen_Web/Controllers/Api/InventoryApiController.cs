using DareZameen_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DareZameen_Web.Models.FeatureClasses;
using DareZameen_Web.Models.Enums;

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
        [HttpGet]
        public object GetAllData()
        {
            var response = new List<InventoryDataModel>();
            var Data = db.Inventory;
            foreach (var d in Data)
            {
                var temp = new InventoryDataModel();
                temp.Id = d.Id;
                temp.AgentId = d.Agent.Id;
                temp.AgentName = d.Agent.FisrtName + " " + d.Agent.LastName;
                temp.CateogryName = d.Category.Name;
                temp.PropertyTypeName = d.PropertyType.Name;
                temp.ReferenceId = d.ReferenceId.Value;
                temp.ReferenceName = d.Reference.Name;
                temp.Size = d.Size.Value;
                temp.Demand = d.Demand.Value;
                temp.Address = d.Address;
                temp.AtFloor = d.AtFloor.Value;
                if (d.IsBasementAvailable.HasValue || d.IsBasementAvailable.Value)
                {
                    temp.BasementSize = d.BasementSize.Value;
                }
                if (d.IsRoofAvailable.HasValue || d.IsRoofAvailable.Value)
                {
                    temp.RoofSize = d.RoofSize.Value;
                }
                temp.QAComments = d.QAComments;
                temp.TotalFloors = d.TotalFloors.Value;
                temp.SpecialLocationId = d.SpecialLocationId.Value;
                // response.SpecialLocationName = d.SpecialLocation
                temp.EnumStatus = ((InventoryStatus)d.Status.Value).ToString();
                temp.Status = d.Status.Value;
                temp.View = d.View.Value;
                temp.ViewName = ((InventoryView)d.View.Value).ToString();
                temp.CreatedAt = d.CreatedAt.Value;
                temp.CreatedBy = d.CreatedBy;
                response.Add(temp);

            }
            return response;
        }


    }
}