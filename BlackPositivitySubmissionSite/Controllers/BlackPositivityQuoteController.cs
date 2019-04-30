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
        public async Task<string> newQuote([FromBody] QuoteSubmissionDto quote)
        {
            var isPersisted = await _qs.AddNewQuote(quote);
            if (isPersisted)
            {
                return "Your quote was submitted successfully. Thank you.";
            }
            else
            {
                return "We're sorry, an unexpected error occurred. Please try again later.";
            }
        }
    }
}