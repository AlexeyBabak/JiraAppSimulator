using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator
{
    class Attachment
    {
        public Attachment(string name, string link, string userId, string taskId)
        {
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();

            Name = name;
            Link = link;
            UserId = userId;
            TaskId = taskId;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }

        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }

        public readonly string UserId;
        public readonly string TaskId;
    }
}