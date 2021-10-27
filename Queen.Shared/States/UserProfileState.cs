using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Queen.Shared.Entity.Models;

namespace Queen.Shared.States
{
    public class UserProfileState
    {
        public List<ClientModel> ClientList { get; set; } = new();
    }
}