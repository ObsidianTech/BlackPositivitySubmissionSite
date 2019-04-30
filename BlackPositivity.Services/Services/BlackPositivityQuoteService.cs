using BlackPositivity.Services.Abstractions.RepoAbstractions;
using BlackPositivity.Services.Abstractions.ServiceAbstractions;
using BlackPositivity.Services.Dtos;
using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackPositivity.Services.Services
{
    public class BlackPositivityQuoteService : IQuoteService
    {
        public IQuoteRepository _qr { get; set;
        }
        public BlackPositivityQuoteService(IQuoteRepository qr)
        {
            _qr = qr;
        }

        public async Task<bool> AddNewQuote(QuoteSubmissionDto quote)
        {
            var newQuote = new BlackPositivtyQuote()
            {
                Quote = quote.Quote,
                Contributor = quote.Contributor,
                hasBeenUsed = false,
                DateAdded = DateTime.Now,
                ID = Guid.NewGuid()
            };
            var isPersisted = await _qr.AddNewQuote(newQuote);
            if (isPersisted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region NotImplemented 
        public BlackPositivtyQuote GetNewQuote()
        {
            throw new NotImplementedException();
        }

        public BlackPositivtyQuote GetQuote()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
