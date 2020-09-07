using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiraAppSimulator
{
    class Comment
    {
        public Comment(string commentText, string authorId, string taskId)
        {
            _createdDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
            Id = Guid.NewGuid().ToString();

            CommentText = commentText;
            AuthorId = authorId;
            TaskId = taskId;
        }

        public string Id { get; set; }
        public string CommentText { get; set; }

        private readonly DateTime _createdDate;
        public DateTime UpdatedDate { get; set; }

        public readonly string AuthorId;
        public readonly string TaskId;
    }
}
