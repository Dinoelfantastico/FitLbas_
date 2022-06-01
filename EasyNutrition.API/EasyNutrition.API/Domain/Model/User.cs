﻿namespace EasyNutrition.API.Domain.Model
{
    public class User
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }
        public bool Active { get; set; }
        public string Linkedin { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
