using Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedOn { get; set; }

        public User(int id, string firstName, string lastName, DateTime createdOn)
        {
            Id = id;

            if(firstName.Length > 255)
            {
                throw new InvalidLength("Max character count for name is 255!");
            }

            if (lastName.Length > 255)
            {
                throw new InvalidLength("Max character count for name is 255!");
            }

            FirstName = firstName;
            LastName = lastName;
            CreatedOn = createdOn;
        }
    }
}
