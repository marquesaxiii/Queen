using Microsoft.AspNetCore.Components;

namespace Queen.Web.Pages
{
    public class PageBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
    }
}