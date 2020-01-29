using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace DebugOnProdC31.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LicensesController : ControllerBase
    {
        public async Task<string> Mit()
        {
            using(HttpClient client = new HttpClient())
            {
                var res = await client.GetAsync("https://opensource.org/licenses/MIT");
                if(res.StatusCode == HttpStatusCode.OK)
                {
                    var rawHtml = await res.Content.ReadAsStringAsync();
                    var doc = new HtmlDocument();
                    doc.LoadHtml(rawHtml);
                    var licence = doc.DocumentNode.SelectSingleNode("//div[id=\"LicenseText\"]").InnerText;
                    return licence;
                }
                else
                {
                    return "Sorry, we can't retrive this licence at the moment. Please contact support to request a copy.";
                }
            }
        }
    }
}