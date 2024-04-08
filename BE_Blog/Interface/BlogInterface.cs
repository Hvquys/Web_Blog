using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Blog.Interface
{
    public interface BlogInterface
    {
        List<post> BlogInsertPost(post post, List<post> lst);
    }
}
