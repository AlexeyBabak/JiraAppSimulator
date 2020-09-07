using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator.Enums
{
    public enum TaskStatuses
    {
        NoTitle = 0,
        Backlog = 1,
        ToDo = 2,
        InProgress = 3,
        ReadyForQA = 4,
        Reopen = 5,
        Done = 6
    }
}
