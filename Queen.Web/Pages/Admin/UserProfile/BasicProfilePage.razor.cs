using Microsoft.AspNetCore.Components;

namespace Queen.Web.Pages.Admin.UserProfile
{
    public class BasicProfilePageBase : PageBase
    
    {
        public void BackToMain()
        {
            NavigationManager.NavigateTo("/signup");
        }
    }
}