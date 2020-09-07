using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator
{
    class User
    {
        public User(string firstName, string lastName, string image)
        {
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();

            FirstName = firstName;
            LastName = lastName;
            Image = image;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }
        
        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }
    }
}
