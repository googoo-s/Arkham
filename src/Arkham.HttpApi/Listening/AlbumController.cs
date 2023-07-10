using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc;

namespace Arkham.HttpApi.Listening;

[Route("[controller]/[action]")]
public class AlbumController : AbpController
{
    private readonly ILogger<AlbumController> _logger;

    public AlbumController(ILogger<AlbumController> logger)
    {
        _logger = logger;
    }

    public  ActionResult<>
}