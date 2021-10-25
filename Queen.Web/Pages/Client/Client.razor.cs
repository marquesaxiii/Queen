using Microsoft.AspNetCore.Components;
using Queen.Shared.Entity.Models;

namespace Queen.Web.Pages.Client
{
    public class ClientBase : ComponentBase
    {
        public ClientModel Client { get; set; } = new();
    }
}