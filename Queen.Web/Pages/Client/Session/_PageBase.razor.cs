using Microsoft.AspNetCore.Components;
using Queen.Shared.States;

namespace Queen.Web.Pages.Client.Session
{
    public class PageBase : Queen.Web.Pages.PageBase
    
    {
        [Inject] public UserProfileState UserProfileState { get; set; }
    }
}