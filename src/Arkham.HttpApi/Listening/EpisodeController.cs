using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc;

namespace Arkham.HttpApi.Listening;

[Route("[controller]/[action]")]
public class EpisodeController : AbpController
{
    private readonly ILogger<EpisodeController> _logger;

    public EpisodeController(ILogger<EpisodeController> logger)
    {
        _logger = logger;
    }
}