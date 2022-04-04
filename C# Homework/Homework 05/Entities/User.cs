using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string FirstName { get; set; }

        [StringLength(255)]
        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public User(int id, string firstName, string lastName, DateTime createdOn)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedOn = createdOn;
        }
    }
}
