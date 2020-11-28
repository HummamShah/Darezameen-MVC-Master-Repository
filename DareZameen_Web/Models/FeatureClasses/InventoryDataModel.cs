using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DareZameen_Web.Models.FeatureClasses
{
    public class InventoryDataModel
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public int ReferenceId { get; set; }
        public string ReferenceName { get; set; }
        public string ReferenceType { get; set; }
        public int CateogryId { get; set; }
        public string CateogryName { get; set; }
        public string PropertyTypeId { get; set; }
        public string PropertyTypeName { get; set; }
        public decimal Size { get; set; }
        public decimal Demand { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string EnumStatus { get; set; }
        public string QAComments { get; set; }
        public bool IsApproced { get; set; }
        public int TotalFloors { get; set; }
        public int AtFloor { get; set; }
        public int View { get; set; }
        public string ViewName { get; set; }
        public bool IsRoofAvailable { get; set; }
        public decimal RoofSize { get; set; }
        public bool IsBasementAvailable { get; set; }
        public decimal BasementSize { get; set; }
        public int SpecialLocationId { get; set; }
        public string SpecialLocationName { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}