using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Post
{
    public class PostManagerment : PostInterface
    {
        public void PostInsert(Post post)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPosts()
        {
            throw new NotImplementedException();
        }
        public List<Post> GetListPost()
        {
            var list = new List<Post>();
            try
            {


                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Post { Title="jjjj", Content="jjjj"});
                }

            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }
    }
}
