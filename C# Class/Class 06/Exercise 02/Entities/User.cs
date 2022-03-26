using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_02.Entities
{
    internal class User
    {
        public int Id { set; get; }

        public string Username { set; get; }

        public string Password { set; get; }

        public string[] Messages { set; get; }

        public User(int userId, string userUsername, string userPassword, string[] userMessages)
        {
            Id = userId;
            Username = userUsername;
            Password = userPassword;
            Messages = userMessages;
        }

        public void PrintMessages()
        {
            foreach (string message in Messages)
            {
                Console.WriteLine(message);
            }
        }

        public string GetIdAndUsername()
        {
            return $"{Id} {Username}";
        }
    }
}
