using BlackPositivity.Services.Abstractions.RepoAbstractions;
using BlackPositivity.Services.Abstractions.ServiceAbstractions;
using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

        public BlackPositivtyQuote AddNewQuote()
        {
            throw new NotImplementedException();
        }

        public BlackPositivtyQuote GetNewQuote()
        {
            throw new NotImplementedException();
        }

        public BlackPositivtyQuote GetQuote()
        {
            throw new NotImplementedException();
        }
    }
}
