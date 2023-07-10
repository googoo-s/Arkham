using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Volo.Abp.AspNetCore.Mvc;

namespace Arkham.HttpApi.Home;

public class HomeController : AbpController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("/")]
    public ActionResult<string> Home()
    {
        _logger.LogInformation(null, "HomeController.Home");
        return "Hello Arkhma";
    }
}
