using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;
using Refit;

namespace GaragemDoCodigoNotify.Controllers
{
    [Route("api/[controller]")]
    public class YoutubeController : Controller
    {
        [HttpGet("Root")]
        public async Task<YoutubeRoot> ListarItems(string xmlYoutube)
        {
            xmlYoutube = "https://www.youtube.com/feeds/videos.xml?channel_id=UCKsSs_S5iXYX-15LtYjLOjQ";
            var rest = RestService.For<IYoutubeService>("https://api.rss2json.com");
            return await rest.Listar(xmlYoutube);
        }
    }
}
