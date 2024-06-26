﻿namespace WebAppApiRest.Core.Models
{
    public class User
    {
        public required int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required bool IsActive { get; set; } = true;
    }
}
