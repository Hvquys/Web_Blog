using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Post
{
    public interface PostInterface
    {
        void PostInsert(Post post);
        List<Post> GetPosts();
    }
}
