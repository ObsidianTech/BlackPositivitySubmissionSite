using BlackPositivity.Services.Abstractions.RepoAbstractions;
using BlackPositivity.Services.DataAccess;
using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlackPositivity.Services.Repositories
{
    public class BlackPositivityQuoteRepository : IQuoteRepository
    {
        public ApplicationDbContext _context { get; set; }

        public BlackPositivityQuoteRepository(ApplicationDbContext context)
        {
            _context = context;
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
