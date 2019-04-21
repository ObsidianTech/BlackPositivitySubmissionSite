using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackPositivity.Services.Abstractions.RepoAbstractions
{
    public interface IQuoteRepository
    {
        BlackPositivtyQuote AddNewQuote();
        BlackPositivtyQuote GetQuote();
        BlackPositivtyQuote GetNewQuote();
    }
}
