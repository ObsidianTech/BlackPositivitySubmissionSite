using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackPositivity.Services.Abstractions.ServiceAbstractions;
using BlackPositivity.Services.Dtos;
using BlackPositivity.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackPositivitySubmissionSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlackPositivityQuoteController : ControllerBase
    {
        public IQuoteService _qs { get; set; }

        public BlackPositivityQuoteController(IQuoteService qs)
        {
            _qs = qs;
        }

        [HttpPost]
        [Route("newQuote/")]
        public async Task<IActionResult> newQuote([FromBody] QuoteSubmissionDto quote)
        {
            if (await _qs.AddNewQuote(quote))
            {
                return Ok(true);
            }
            else
            {
                return StatusCode(500, false);
            }
        }
    }
}