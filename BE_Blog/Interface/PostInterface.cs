using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BE_Blog.Interface
{
    public interface PostInterface
    {
        void PostInsertComment(Comment comment, List<Comment> lst);
    }
}
