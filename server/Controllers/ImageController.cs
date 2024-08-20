using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImageController : ControllerBase
{
    private readonly ILogger<ImageController> _logger;

    public ImageController(ILogger<ImageController> logger)
    {
        _logger = logger;
    }

    // TODO: either implement an enpoint that returns medialink or the image
    // data.

    [HttpPost]
    public IActionResult Upload(IFormFile file)
    {
        // TODO: upload image to Cloud Storage.
        throw new NotImplementedException("Upload not implemented yet.");
    }
}
