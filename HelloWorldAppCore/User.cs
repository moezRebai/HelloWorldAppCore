using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldAppCore
{
    public class User
    {
        public User(string firstname, string lastname)
        {
            Id = new Guid();
            FirstName = firstname;
            LastName = lastname;
            CreationDate = DateTime.Now;
            ModificationDate = DateTime.Now;
        }

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime ModificationDate { get; set; }

        public override string ToString()
        {
            return "This is Mr : " + FirstName.ToUpper() + " " + LastName.ToUpper(); 
        }
    }
}
