using CustomConfigurationFile.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Annotations;

namespace CustomConfigurationFile.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationsController : ControllerBase
    {
        private readonly ErrorMessages _errorMessages;

        public ConfigurationsController(IOptions<ErrorMessages> errorMessages) 
        {
            ArgumentNullException.ThrowIfNull(errorMessages, nameof(errorMessages));
            ArgumentNullException.ThrowIfNull(errorMessages.Value, nameof(errorMessages.Value));

            _errorMessages = errorMessages.Value;
        }

        [HttpGet("")]
        [SwaggerOperation(OperationId = "getErrorMessages", Description = "API to retrieve Error Messages from custom configuration/settings file.")]
        [SwaggerResponse(StatusCodes.Status200OK, type: typeof(ErrorMessages))]
        public IActionResult GetErrorMessages()
        {
            return Ok(_errorMessages);
        }
    }
}
