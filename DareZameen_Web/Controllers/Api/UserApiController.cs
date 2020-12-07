using DareZameen_Web.Models.FeatureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DareZameen_Web.Models.Feature.User;
using System.Web.Mvc;
using DareZameen_Web.Models;
using System.Threading.Tasks;
using static DareZameen_Web.Controllers.AccountController;
using Microsoft.AspNet.Identity;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using DareZameen_Web.Models.Enums;

namespace DareZameen_Web.Controllers.Api
{
    public class UserApiController : ApiController
    {
        private ApplicationUserManager _userManager;
        private RealStateDataEntities db = new RealStateDataEntities();
        private static List<string> LeadsRoles = new List<string>(new string[] { Roles.Lead, Roles.Lead_Add, Roles.Lead_PreSales, Roles.Lead_Sales });
        private static List<string> DesignerRoles = new List<string>(new string[] { Roles.Inventory_Supplier});
        public UserApiController()
        {
            _userManager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
           
        }
        // GET api/<controller>
        [System.Web.Http.HttpGet]
       
        public object GetListData()
        {
            var result = new object();
            if (User.IsInRole(Roles.Admin))
            {
                var temp = new GetListingRequest();
                result = temp.RunRequest();
                
            }
            if (User.IsInRole(Roles.Inventory_Supplier))
            {
                var temp = new GetListingRequest();
                result = temp.RunRequest();

            }
            return result;

        }
        // POST: /Account/Register
        [System.Web.Http.HttpPost]
        [System.Web.Http.Authorize(Roles= "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<object> RegisterUser(RegisterUserViewModel model)
        {
            var response = new RegisterUserResponse();
            var RolesToBeAdded = new List<string>();
            if (ModelState.IsValid && model.ConfirmPassword == model.Password)
            {

                var user = new ApplicationUser { UserName = model.Email, Email = model.Email }; //We can put username field instead of email
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    var CurrentUserName = User.Identity.Name;
                    var AgentData = new Agent();
                    AgentData.UserId = user.Id;
                    AgentData.Designation = model.Designation;
                    AgentData.FisrtName = model.FirstName;
                    AgentData.LastName = model.LastName;
                    AgentData.Address = model.Address;
                    AgentData.Contact1 = model.Contact1;
                    AgentData.Contact2 = model.Contact2;
                    AgentData.CreatedAt = DateTime.Now;
                    AgentData.CreatedBy = CurrentUserName;
                    AgentData.Email = model.Email;
                    var AgentResult = db.Agent.Add(AgentData);



                   
                    if (AgentData.Designation == (int) Designation.Leads)
                    {
                        RolesToBeAdded = LeadsRoles;
                    }
                    if (AgentData.Designation == (int)Designation.Desinger)
                    {
                        RolesToBeAdded = DesignerRoles;
                    }

                    var RoleResult = await _userManager.AddToRolesAsync(user.Id, RolesToBeAdded.ToArray());
                    if (RoleResult.Succeeded)
                    {
                        response.IsRoleAdded = true;
                    }
                    else
                    {
                        response.IsRoleAdded = false;
                    }
                    
                    db.SaveChanges();
                    response.Success = true;
                    // await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

                    return response;
                }
                response.Success = false;
                response.ValidationErrors = (result.Errors);
            }

            // If we got this far, something failed, redisplay form
            return response;
        }

    }
}