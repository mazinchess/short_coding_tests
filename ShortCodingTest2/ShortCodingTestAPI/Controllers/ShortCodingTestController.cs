using Microsoft.AspNetCore.Mvc;
using ShortCodingServices;
using System;
using System.Net;

namespace ShortCodingTestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/tests")]
    public class ShortCodingTestController : Controller
    {
        private readonly IListifyService _listifyService;

        public ShortCodingTestController(IListifyService listifyService)
        {
            _listifyService = listifyService ??
            throw new ArgumentNullException(nameof(listifyService));
        }

        /// <summary>
        /// Get an specific element from a numbers range defined by begin and end numbers.
        /// </summary>
        /// <param name="begin">Starting number of the range. Default: 1.</param>
        /// <param name="end">Ending number of the range. Default: 20.</param>
        /// <param name="index">Desired index within the range.</param>
        [HttpGet("listify")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Get([FromQuery] int? begin, [FromQuery] int? end, [FromQuery] int index)
        {
            if (begin < 0)
            {
                return BadRequest("Invalid starting range number");
            }
            if (end > int.MaxValue)
            {
                return BadRequest("Invalid ending range number");
            }
            if (end <= begin)
            {
                return BadRequest("Ending range number must be greater than starter range number");
            }
            if (index < 0 || index > (end - begin))
            {
                return BadRequest("The specified index is out range");
            }
            var element = _listifyService.GetElement(begin ?? 1, end ?? 20, index);
            return Ok(element);
        }
    }
}