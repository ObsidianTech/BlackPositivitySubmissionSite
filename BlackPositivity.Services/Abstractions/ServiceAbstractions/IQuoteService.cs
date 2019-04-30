using BlackPositivity.Services.Dtos;
using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackPositivity.Services.Abstractions.ServiceAbstractions
{
    public interface IQuoteService
    {
        Task<bool> AddNewQuote(QuoteSubmissionDto quote);
        BlackPositivtyQuote GetQuote();
        BlackPositivtyQuote GetNewQuote();
    }
}
