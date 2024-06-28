using System;
using System.Collections.Generic;

namespace SampleProjectStructure.Models.Entities
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Address { get; set; }
    }
}
