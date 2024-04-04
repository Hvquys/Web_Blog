using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Blog.Post
{
    public class Post
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DatePublished { get; set; }
        public List<Comment> Comments { get; } = new List<Comment>();

        // Hàm khởi tạo
        public Post(string title, string content)
        {
            Title = title;
            Content = content;
            DatePublished = DateTime.Now;
        }
    }
}
