using BlackJack.Core.Abstractions.IServices;
using BlackJack.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackJackController : ControllerBase
    {
        private readonly IBlackJackLogicService _blackJackLogicService;
        public BlackJackController(IBlackJackLogicService blackJackLogicService)
        {
                _blackJackLogicService = blackJackLogicService;
        }
        [HttpPost]
        public IActionResult GetAction(Hand hand)
        {
            var test= _blackJackLogicService.IsBust(hand);
            return Ok(test);
        }
    }
}
