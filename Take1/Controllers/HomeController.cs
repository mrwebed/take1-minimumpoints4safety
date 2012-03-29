using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace Take1.Controllers
{
    public class HomeController : Controller
    {
        //    //
        //    // GET: /Home/

        //    public ActionResult Index()
        //    {
        //        return View();
        //    }

        //}

        //public static




   //     public ActionResult Index()
   //     {
   //HtmlWeb htmlWeb = new HtmlWeb();
   ////HtmlNodeCollection links = new HtmlNodeCollection();
   //string url = @"http://www.bbc.co.uk/sport/football/results/partial/competition-118996114";

   //HtmlDocument doc = htmlWeb.Load(url);

   //HtmlNodeCollection links = doc.DocumentNode.SelectNodes("//tr[@id]"); //abbr[@title='Score']");     //Descendants("//abbr[@title='Score']").Select(x => x.InnerHtml).ToString();
   ////var details = links.Elements("ts class=match-details");
   ////HtmlNodeCollection teams;
   ////         foreach (HtmlNode derp in details)
   ////         teams = derp.SelectNodes("p[starts-with(@class,'team-')]");
   ////         foreach ( HtmlNode herp in teams)
   ////             herp
   ////List<string> date = new List<string>();         
   //string date;

   //         //   string score;
   ////HtmlNode derp1;
   //       //  string hteam;

   //         foreach (HtmlNode derp in links)
   //         {
   //            // derp1 = derp.SelectNodes("//p[starts-with(@class,'team-')]";
   //             ViewBag.score = derp.SelectSingleNode("//abbr[@title='Score']").InnerText;
   //             ViewBag.hteam = derp.SelectSingleNode("//p[(@class='team-home teams')]").InnerText;
   //             ViewBag.ateam = derp.SelectSingleNode("//p[(@class='team-away teams')]").InnerText;
   //             date = derp.SelectSingleNode("//td[(@class='match-date')]").InnerText;
   //          //  ViewBag.time = derp.SelectSingleNode("//td[(@class='time')]").InnerText;
   //     }
   //    // hteam = derp.SelectSingleNode("//p[starts-with(@class,'team-')]".InnerText;




   //         ////HtmlNodeCollection output = new HtmlNodeCollection();
   //         ////var output
   //         ////HtmlDocument htmlDoc = new HtmlDocument();
   //         //// There are various options, set as needed
   //         ////htmlDoc.OptionFixNestedTags = true;
   //         //HtmlWeb hWeb = new HtmlWeb();

   //         //string url = "http://www.bbc.co.uk/sport/football/results/partial/competition-118996114";

   //         //// filePath is a path to a file containing the html
   //         ////hWeb.Load(url);
   //         //HtmlDocument htmlDoc = new HtmlDocument();
   //         //htmlDoc = hWeb.Load(url);

   //         //var bodyNodes = htmlDoc.DocumentNode.SelectNodes("//tr[@id]");
   //         //string[] output = new string[380];
   //         //int i = 0;   

   //         //foreach (var tag in bodyNodes)
   //         //{
   //         //   // int i = 0;   
   //         //   string s = tag.SelectSingleNode("td[2]").InnerText;    /////[@class='match-details']");        //p[@class=team-home teams");
   //         //    i = i ++;
   //         //    output[i] = s;

   //         //}
   //         ////int bodyNode = 1;
   //         //ViewBag.message = //output; // bodyNode 
   //         //    links;
   //return View();
   //     }
        public ActionResult Index()
        {
            return View();
        }
    }
}