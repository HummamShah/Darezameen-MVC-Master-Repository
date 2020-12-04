using DareZameen_Web.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DareZameen_Web.Models.Feature.User
{
    
	public class GetListingResponse
	{
		public List<AgentData> Data { get; set; }
	}
	public class AgentData
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
	public class GetListingRequest
	{
		private  RealStateDataEntities _dbContext = new RealStateDataEntities();
		public object RunRequest()
		{
			var response = new GetListingResponse();
			response.Data = new List<AgentData>();
			var Data = _dbContext.Agent;
			foreach (var d in Data)
			{
				var temp = new AgentData();
				temp.Id = d.Id;
				temp.UserId = d.UserId;
				temp.FirstName = d.FisrtName;
				temp.LastName = d.LastName;
				temp.ImageUrl = d.ImageUrl;
				temp.IsActive = d.IsActive;
				temp.Email = d.Email;
				temp.Designation = (d.Designation);
				temp.DesignationEnum = ((Designation)d.Designation).ToString();
				temp.Address = d.Address;
				temp.Contact1 = d.Contact1;
				temp.Contact2 = d.Contact2;
				temp.CreatedAt = d.CreatedAt;
				temp.CreatedBy = d.CreatedBy;
				response.Data.Add(temp);
			}
			return response;
		}
	}
}