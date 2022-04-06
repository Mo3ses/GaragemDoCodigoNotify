using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IYoutubeService
    {
     [Get("/v1/api.json?rss_url={xmlLink}")]
     Task<YoutubeRoot> Listar(string xmlLink);
    }
}
