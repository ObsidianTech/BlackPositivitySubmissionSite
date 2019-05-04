using BlackPositivity.Services.Abstractions.RepoAbstractions;
using BlackPositivity.Services.DataAccess;
using BlackPositivity.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlackPositivity.Services.Repositories
{
    public class BlackPositivityQuoteRepository : IQuoteRepository
    {
        public ApplicationDbContext _context { get; set; }

        public BlackPositivityQuoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddNewQuote(BlackPositivtyQuote newQuote)
        {
            try
            {
                await _context.BlackPositivityQuotes.AddAsync(newQuote);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #region Not Implemented
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
