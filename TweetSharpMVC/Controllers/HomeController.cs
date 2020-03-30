using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TweetSharp;

namespace TweetSharpMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtTwitterName)
        {
            //TwitterService ("consumer key" , "consumer secret")
            var service = new TwitterService("cf5bBLatUzNL124LmXi3SkF7A", "ihhOa7SwUSwvQJVUzwgTlK1Il80Mls2v3DfHYHiKBiszNsXexi");
            // AuthenticateWith ("Access Token" , "AccessTokenSecret");
            service.AuthenticateWith("1120280773754544128-rpWzUacYFzxCFYuRyMlF7fbHJw6Kjo", "4QIqoU3s9FJ3QXoZS7Qazygv3JKrzjKNH7RhB90crg1IY");

            IEnumerable<TwitterStatus> tweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions { ScreenName = txtTwitterName, Count = 10, IncludeRts = false,ExcludeReplies = true });

            ViewBag.Tweets = tweets;
            return View();

            

        }
    }
}