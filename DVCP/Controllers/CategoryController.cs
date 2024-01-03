using DVCP.Models;
using DVCP.ViewModel;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using System.Web.Mvc;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Web.UI.WebControls;
using static System.Net.WebRequestMethods;

namespace DVCP.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Dansinh(int? page)
        {
            
            string url = "https://vnexpress.net/thoi-su/dan-sinh";
           
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
           
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

          
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
           
            List<Post> newsList = new List<Post>();
          
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < desnodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            int pageSize = 10; // Số bài viết trên mỗi trang
            int pageNumber = (page ?? 1);

            // Trả về một trang đã phân trang của danh sách bài viết
            return View(newsList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult LDVL(int? page)
        {
           
            string url = "https://vnexpress.net/thoi-su/lao-dong-viec-lam";
          
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
           
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

         
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
          
            List<Post> newsList = new List<Post>();
            
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < desnodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            int pageSize = 10; // Số bài viết trên mỗi trang
            int pageNumber = (page ?? 1);

            // Trả về một trang đã phân trang của danh sách bài viết
            return View(newsList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Giaothong()
        {
           
            string url = "https://vnexpress.net/thoi-su/giao-thong";
         
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
          
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

           
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
          
            List<Post> newsList = new List<Post>();
          
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < nodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            return View(newsList);
        }

        public ActionResult Chungkhoan()
        {
            
            string url = "https://vnexpress.net/kinh-doanh/chung-khoan";
           
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
           
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

            
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
         
            List<Post> newsList = new List<Post>();
          
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < imgnodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            return View(newsList);
        }

        public ActionResult Quocte(int? page)
        {
           
            string url = "https://vnexpress.net/kinh-doanh/quoc-te";
           
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
          
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

         
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
          
            List<Post> newsList = new List<Post>();
          
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < imgnodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            int pageSize = 10; // Số bài viết trên mỗi trang
            int pageNumber = (page ?? 1);

            // Trả về một trang đã phân trang của danh sách bài viết
            return View(newsList.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Doanhnghiep()
        {
         
            string url = "https://vnexpress.net/kinh-doanh/doanh-nghiep";
           
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
          
            string xpathExpression = "//h2[@class='title-news']/a";
            string imgExpression = "//div[@class='thumb-art']/a/picture/img";
            string desExpression = "//p[@class='description']/a";

          
            var nodes = doc.DocumentNode.SelectNodes(xpathExpression);
            var imgnodes = doc.DocumentNode.SelectNodes(imgExpression);
            var desnodes = doc.DocumentNode.SelectNodes(desExpression);
          
            List<Post> newsList = new List<Post>();
          
            if (nodes != null || imgnodes != null || desnodes != null)
            {
                for (int i = 0; i < imgnodes.Count; i++)
                {
                    string title = nodes[i].InnerText.Trim();
                    string imageurl = imgnodes[i].GetAttributeValue("src", "");
                    string des = desnodes[i].InnerText.Trim();
                    string articleUrl = desnodes[i].GetAttributeValue("href", "");


                    if (!string.IsNullOrEmpty(title) &&
                            !string.IsNullOrEmpty(imageurl) &&
                                !string.IsNullOrEmpty(des))
                    {
                        Post news = new Post
                        {
                            Title1 = title,
                            img = imageurl,
                            des = des,
                            Url = articleUrl
                        };

                        newsList.Add(news);
                    }
                }

            }
            return View(newsList);
        }
    }
}