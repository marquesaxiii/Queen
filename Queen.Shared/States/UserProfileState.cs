using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Queen.Shared.States
{
    public class UserProfileState
    {
        [Inject]
        public UserProfileState State { get; set; }
        
        public List<string> FullNameList { get; set; } = new();

    }
}