using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackPositivity.Services.Abstractions.ServiceAbstractions
{
    public interface IQuoteService
    {
        BlackPositivtyQuote AddNewQuote();
        BlackPositivtyQuote GetQuote();
        BlackPositivtyQuote GetNewQuote();
    }
}
