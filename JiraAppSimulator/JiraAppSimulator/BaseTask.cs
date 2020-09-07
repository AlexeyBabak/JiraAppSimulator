using JiraAppSimulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator
{
    abstract class BaseTask
    {
        public BaseTask(double estimation, TaskTypes type, string title, string description, User taskcreator, User owner, TaskStatuses status = TaskStatuses.Backlog)
        {
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;

            Estimation = estimation;
            Type = type;
            Title = title;
            Description = description;
            Id = Guid.NewGuid().ToString();
            creator = taskcreator;
            Owner = owner;
            Status = status;
        }

        public double Estimation { get; set; }

        public TaskTypes Type { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Id { get; set; }

        private readonly DateTime _createdDate;
        
        public DateTime UpdatedDate { get; set; }

        private User Owner { get; set; }

        public readonly User creator;

        public TaskStatuses Status { get; set; }


        public abstract void GetInfo();

    }
}
