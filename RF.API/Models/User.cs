using System;
using System.Collections.Generic;

namespace RF.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateTime DateOfBirth { get; set; }
        public DateTime Created { get; set; }
        public string Bio { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<JobFunction> JobFunctions { get; set; }
        public int JobFunctionId { get; set; }
    }
}