using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Blog.Interface
{
    public class BlogManagerment : BlogInterface
    {
        public void BlogInsertPost(post post, List<post> lst)
        {
            lst.Add(post);
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
        public List<Comment> GetListComment()
        {
            var list = new List<Comment>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    list.Add(new Comment { AuthorName = "AuthorName" + i, Content = "Content1" + i });
                }

            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }
        public List<post> GetListPost()
        {
            var list = new List<post>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    list.Add(new post { Title = "Title" + i, Content = "Content" + i + ": Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", 
                        Comments = GetListComment()});
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
