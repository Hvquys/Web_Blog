using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog
{
    public class Comment
    {
        public string AuthorName { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; }

        // Hàm khởi tạo
        public Comment(string authorName, string content)
        {
            AuthorName = authorName;
            Content = content;
            DatePublished = DateTime.Now;
        }
    }
}
