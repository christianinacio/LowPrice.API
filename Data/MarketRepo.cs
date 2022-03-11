using System.Collections.Generic;
using LowPrice.API.Domain.Models;

namespace LowPrice.API.Data
{
    public class MarketRepo : IMarketRepo
    {
        private readonly DataContext _context;

        public MarketRepo(DataContext context)
        {
            _context = context;
        }
        public Market AddMarket(Market market)
        {
            var branch = _context.Markets.Add(market).Entity;
            _context.SaveChanges();
            return market;
        }
    }
}