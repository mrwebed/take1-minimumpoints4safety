using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlAgilityPack;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using Take1.Models;

namespace Take1.Controllers
{
    public class datascraperController : Controller
    {
        //
        // GET: /datascraper/

        public ActionResult Index()
        {
            return View();
        }
        public datascraper()
        {
            string url = @"http://www.bbc.co.uk/sport/football/results/partial/competition-118996114";          
            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlDocument doc = new HtmlDocument{ OptionUseIdAttribute = true };

            doc = htmlWeb.Load(url);
            HtmlNodeCollection mtchrslts = doc.DocumentNode.SelectNodes("//tr[@id]");

            string date; 
            string ateam; 
            string hteam; 
            string score;
            string idmess;
            string idnum;
            string[] teamscores;
            string teamscoreh;
            string teamscorea;

            foreach (HtmlNode matchresult in mtchrslts)
            {
                idmess = matchresult.SelectSingleNode("//tr[@id]").Id;
                idnum = idmess.Replace("match-row-", "");
                score = matchresult.SelectSingleNode("//abbr[@title='Score']").InnerText;
                teamscores = score.Split('-');
                teamscoreh = teamscores[0];
                teamscorea = teamscores[1];
                hteam = matchresult.SelectSingleNode("//p[(@class='team-home teams')]").InnerText;
                ateam = matchresult.SelectSingleNode("//p[(@class='team-away teams')]").InnerText;
                date = matchresult.SelectSingleNode("//td[(@class='match-date')]").InnerText;
            }

            return;
        }
    }
}
