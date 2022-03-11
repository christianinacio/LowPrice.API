using System.Collections.Generic;
using LowPrice.API.Domain.Models;

namespace LowPrice.API.Data
{
    public interface IMarketRepo
    {
        Market AddMarket(Market market);
    }
}