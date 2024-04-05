using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Interface
{
    public interface BlogInterface
    {
        void BlogInsertPost(post post, List<post> lst);
    }
}
