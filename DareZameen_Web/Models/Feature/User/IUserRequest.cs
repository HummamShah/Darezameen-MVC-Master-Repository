using DareZameen_Web.Models.Enums;
using DareZameen_Web.Models.FeatureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DareZameen_Web.Models.Feature.User
{
    public static class IUserRequest
    {
        private static RealStateDataEntities db = new RealStateDataEntities();
        public static object GetListing()
        {
            var response = new List<AgentDataModel>();
            var Data = db.Agent;
            foreach (var d in Data)
            {
                var temp = new AgentDataModel();
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
                response.Add(temp);
            }



            return response;
        }
        public static object GetUserById(int Id)
        {
            var response = new AgentDataModel();
            var Data = db.Agent.Where(x => x.Id == Id).FirstOrDefault();
            response.Id = Data.Id;
            response.UserId = Data.UserId;
            response.FirstName = Data.FisrtName;
            response.LastName = Data.LastName;
            response.ImageUrl = Data.ImageUrl;
            response.IsActive = Data.IsActive;
            response.Email = Data.Email;
            response.Designation = (Data.Designation);
            response.DesignationEnum = ((Designation)Data.Designation).ToString();
            response.Address = Data.Address;
            response.Contact1 = Data.Contact1;
            response.Contact2 = Data.Contact2;
            response.CreatedAt = Data.CreatedAt;
            response.CreatedBy = Data.CreatedBy;
            return response;
        }

    }
    

}
