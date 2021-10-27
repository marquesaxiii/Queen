using System.Reflection.Metadata;

namespace Queen.Web.Pages.Client.Session
{
    public class OtpPageBase : PageBase
    {
        public void GetOtp()
        {
            NavigationManager.NavigateTo("#");
        }
    }
}