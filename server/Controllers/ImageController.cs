using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ImageController : ControllerBase
{
    private readonly ILogger<ImageController> _logger;

    public ImageController(ILogger<ImageController> logger)
    {
        _logger = logger;
    }

    // TODO implement endpoint up upload image to Cloud Storage.
    // Then either implement an enpoint that returns the URL to uploaded image
    // or the image data.
}
