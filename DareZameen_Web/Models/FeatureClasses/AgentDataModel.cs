using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DareZameen_Web.Models.FeatureClasses
{
    public class AgentDataModel
    {
		public int Id { get; set; }
		public string UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Contact1 { get; set; }
		public string Contact2 { get; set; }
		public string Address { get; set; }
		public int? Designation { get; set; }
		public string DesignationEnum { get; set; }
		public string Email { get; set; }
		public string ImageUrl { get; set; }
		public bool? IsActive { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedAt { get; set; }

		
	}
}