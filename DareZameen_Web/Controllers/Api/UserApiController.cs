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

namespace DareZameen_Web.Controllers.Api
{
    public class UserApiController : ApiController
    {
        //private ApplicationSignInManager _signInManager;
        //private ApplicationUserManager _userManager;
        //private RealStateDataEntities db = new RealStateDataEntities();
        //public UserApiController(ApplicationUserManager userManager, ApplicationSignInManager signInManager) 
        //{
        //     _userManager= HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    _signInManager = HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
        //}
        // GET api/<controller>
        [System.Web.Http.HttpGet]
        public object GetAllData()
        {
            var temp = IUserRequest.GetListing();
            return temp;
        }
       //// POST: /Account/Register
       //[System.Web.Http.HttpPost]
       //[System.Web.Http.AllowAnonymous]
       //[ValidateAntiForgeryToken]
       // public async Task<object> RegisterUser(RegisterUserViewModel model)
       // {

       //     var response = new RegisterUserResponse();
       //     if (ModelState.IsValid)
       //     {

       //         var user = new ApplicationUser { UserName = model.Email, Email = model.Email }; //We can put username field instead of email
       //         var result = await _userManager.CreateAsync(user, model.Password);

       //         if (result.Succeeded)
       //         {
       //             var CurrentUserName = User.Identity.Name;
       //             var AgentData = new Agent();
       //             AgentData.UserId = user.Id;
       //             AgentData.FisrtName = model.FirstName;
       //             AgentData.LastName = model.LastName;
       //             AgentData.Address = model.Address;
       //             AgentData.Contact1 = model.Contact1;
       //             AgentData.Contact2 = model.Contact2;
       //             AgentData.CreatedAt = DateTime.Now;
       //             AgentData.CreatedBy = CurrentUserName;
       //             var AgentResult = db.Agent.Add(AgentData);

       //             response.Success = true;
       //             // await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

       //             // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
       //             // Send an email with this link
       //             // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
       //             // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
       //             // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");

       //             return response;
       //         }
       //         response.Success = false;
       //         response.ValidationErrors = (result.Errors);
       //     }

       //     // If we got this far, something failed, redisplay form
       //     return response;
       // }

    }
}