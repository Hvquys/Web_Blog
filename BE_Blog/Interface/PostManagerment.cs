using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BE_Blog.Interface
{
    public class PostManagerment : PostInterface
    {
        public void PostInsertComment(Comment comment, List<Comment> lst)
        {
            lst.Add(comment);
        }

        public post GetPost(String titlePost, List<post> lst)
        {
            foreach (var post in lst)
            {
                if (post.Title == titlePost)
                {
                    return post;
                }
            }
            return null;
        }
    }
}
