using Microsoft.AspNetCore.Components;
using Queen.Shared.Entity.Models;

namespace Queen.Web.Pages.Client.Session
{
    public class SignUpPageBase : PageBase
    {
        public ClientModel Client { get; set; } = new();

        public void UserDetails()
        {
            UserProfileState.ClientList.Add(Client);

            NavigationManager.NavigateTo("/basicprofile");
        }
    }
}