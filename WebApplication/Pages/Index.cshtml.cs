using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace OpenSourceSCORMLMS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public IndexModel(UserManager<IdentityUser> _User, SignInManager<IdentityUser> SignIn)
        {
            _userManager = _User;
            _signInManager = SignIn;

        }
        public void OnGet()
        {
            if (_signInManager.IsSignedIn(User))
            {
                SignedInUser.User_id =  _userManager.GetUserId(User);
                SignedInUser.Email =  _userManager.GetUserName(User);
                SignedInUser.isSignedIn = true;
            }
        }
    }
}
