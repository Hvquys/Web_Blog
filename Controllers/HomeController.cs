using BE_Blog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Web_Blog.Models;

namespace Web_Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<post>();
            try
            {
                list = new BE_Blog.Interface.BlogManagerment().GetListPost();
            }
            catch (Exception ex)
            {

                throw;
            }
            // Lưu ArrayList vào Session
            Session["PostLists"] = list;
            return View();
        }

        public ActionResult ListPostsPartialView()
        {
            var list = new List<post>();
            try
            {
                if (Session["PostLists"] != null && Session["PostLists"] is List<post>)
                {
                    list = (List<post>)Session["PostLists"];
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView(list);
        }

        public JsonResult PostInsert(post post)
        {
            var returnData = new ResponseData();
            try
            {
                var list = new List<post>();
                if (Session["PostLists"] != null && Session["PostLists"] is List<post>)
                {
                    list = (List<post>)Session["PostLists"];
                }
                if (post == null ||
                    string.IsNullOrEmpty(post.Title)
                    || string.IsNullOrEmpty(post.Content))
                {
                    returnData.Code = -1;
                    returnData.Description = "Dữ liệu đầu vào không hợp lệ";
                    return Json(returnData, JsonRequestBehavior.AllowGet);

                }

                // INSERT DỮ LIỆU
                // gọi interface

                var req = new post
                {
                    Title = post.Title,
                    Content = post.Content,
                    Comments = new BE_Blog.Interface.BlogManagerment().GetListComment()
                };


                var lstResponse = new BE_Blog.Interface.BlogManagerment().BlogInsertPost(req, list);
                Session["PostLists"] = lstResponse;


                returnData.Code = 1;
                returnData.Description = "Title : " + post.Title ;
                return Json(returnData, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {

                throw;
            }

            return Json(returnData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PostDetail(String id)
        {
            var list = new List<post>();
            var post = new post();
            try
            {
                if (Session["PostLists"] != null && Session["PostLists"] is List<post>)
                {
                    list = (List<post>)Session["PostLists"];
                }
                post = new BE_Blog.Interface.BlogManagerment().GetPost(id, list);

            }
            catch (Exception ex)
            {

                throw;
            }
            return View(post);
        }

        public ActionResult PostsPartialView(String id)
        {
            var list = new List<post>();
            var listSearch = new List<post>();
            var post = new post();
            try
            {
                if (Session["PostLists"] != null && Session["PostLists"] is List<post>)
                {
                    list = (List<post>)Session["PostLists"];
                }
                post = new BE_Blog.Interface.BlogManagerment().GetPost(id, list);

                listSearch.Add(post);
            }
            catch (Exception ex)
            {

                throw;
            }
            return View(listSearch);
        }
        public ActionResult ListCommentsPartialView(string title)
        {
            var list = new List<post>();
            var listComments = new List<Comment>();
            var post = new post();
            try
            {
                if (Session["PostLists"] != null && Session["PostLists"] is List<post>)
                {
                    list = (List<post>)Session["PostLists"];
                }
                post = new BE_Blog.Interface.BlogManagerment().GetPost(title, list);
                listComments = post.Comments;

            }
            catch (Exception ex)
            {

                throw;
            }
            return PartialView(listComments);
        }
    }
}