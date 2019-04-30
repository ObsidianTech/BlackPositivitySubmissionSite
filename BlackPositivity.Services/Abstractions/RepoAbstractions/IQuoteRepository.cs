using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackPositivity.Services.Abstractions.RepoAbstractions
{
    public interface IQuoteRepository
    {
        Task<bool> AddNewQuote(BlackPositivtyQuote newQuote);
        BlackPositivtyQuote GetQuote();
        BlackPositivtyQuote GetNewQuote();
    }
}
