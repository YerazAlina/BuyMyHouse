﻿namespace BuyMyHouse.Models
{
    public class User
    {
        //User: Name, Username, Password, Income, Email adress
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public float Income { get; set; }

    }
}
