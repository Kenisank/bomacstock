using AutoMapper;
using Microsoft.AspNet.Identity;
using BomacApp.Core.Resources.Accounts;
using BomacApp.Domain.Model;
using BomacApp.Domain.Services.Interfaces;
using System.Threading.Tasks;
using System.Web.Http;

namespace BomacApp.Core.Controllers
{

    [Authorize]
    [RoutePrefix("api/accounts")]
    public class UserAccountsController : BaseApiController
    {

        private readonly IEmailSender _emailSender;


        public UserAccountsController() { }


        public UserAccountsController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }


        [AllowAnonymous]
        [Route("register")]
        [HttpPost]

        public async Task<IHttpActionResult> Register([FromBody] RegisterResources model)

        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = Mapper.Map<RegisterResources, ApplicationUser>(model);
            user.UserName = user.Email;
            IdentityResult result = await AppUserManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return GetErrorResult(result);


            return Ok("user created successfully");

        }

        [Route("profile")]
        [HttpGet]
        public async Task<IHttpActionResult> GetUserProfile()
        {

            var userid = User.Identity.GetUserId();
            var user = await AppUserManager.FindByIdAsync(userid);
            if (user == null)
                return NotFound();
            var resources = Mapper.Map<ApplicationUser, ProfileResources>(user);
            resources.Roles = AppUserManager.GetRolesAsync(userid).Result;



            return Ok(resources);




        }

        [AllowAnonymous]
        [Route("setpassword")]
        public async Task<IHttpActionResult> SetPassword([FromBody] SetPasswordResources resources)
        {

            var user = await AppUserManager.FindByEmailAsync(resources.Email);

            if (user == null)
                return BadRequest("Password could not be set");

            var result = await AppUserManager.AddPasswordAsync(user.Id, resources.NewPassword);
            if (!result.Succeeded)
                return GetErrorResult(result);

            return Ok("password added successfully");
        }


        [HttpPost]
        [Route("changepassword")]

        public async Task<IHttpActionResult> ChangePassword([FromBody]ChangePasswordResources model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            IdentityResult result = await AppUserManager.ChangePasswordAsync(User.Identity.GetUserId(), model.OldPassword,
                model.Password);

            if (!result.Succeeded)
            {
                return GetErrorResult(result);
            }

            return Ok("password has been changed");
        }

        //[HttpGet]
        //[AllowAnonymous]
        //[Route("forgotpassword")]
        //public async Task<IHttpActionResult> ForgotPassword(string email)
        //{

        //    if (email == null)
        //    {

        //        return BadRequest("email is required");
        //    }

        //    var user = await AppUserManager.FindByNameAsync(email);
        //    if (user == null /*|| !(await AppUserManager.IsEmailConfirmedAsync(user.Id))*/)
        //    {
        //        // Don't reveal that the user does not exist or is not confirmed
        //        return BadRequest("something failed");
        //    }

        //    // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
        //    // Send an email with this link
        //    string code = await AppUserManager.GeneratePasswordResetTokenAsync(user.Id);


        //    var callbackUrl = "http://mbbov.renttio.com/account/resetpassword/?" + "email=" + user.Email + "&code=" + code;
        //    var message = $"Please reset your password by clicking on the button below";

        //    //send the email notification

        //    //  emailNotify.ResetPassword(callbackUrl.ToString(), message, user.Email);
        //    BackgroundJob.Enqueue(() => _emailSender.ResetPassword(callbackUrl.ToString(), user.Email, user.Name));

        //    return Ok("check your mail to activate your account");
        //}


        [HttpPost]
        [AllowAnonymous]
        [Route("reset")]
        public async Task<IHttpActionResult> ResetPassword([FromBody]ResetPasswordResources model)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await AppUserManager.FindByNameAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                // return RedirectToAction("ResetPasswordConfirmation", "Account");

                return BadRequest("something failed");
            }

            var result = await AppUserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            if (result.Succeeded)
            {
                return Ok("password has been resetted");
            }
            return GetErrorResult(result);

        }
        //[Route("logout")]
        //[HttpGet]
        //public IHttpActionResult Logout()
        //{
        //    Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
        //    return Ok("user logout successfully");
        //}


    }
}
