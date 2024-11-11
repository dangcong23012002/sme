using Microsoft.EntityFrameworkCore;
using SMe.Models.Database;
using SMe.Models.Domains;
using SMe.Models.Interfaces;

namespace SMe.Models.Repositories
{
    public class ShopRepository : IShopRepository
    {
        private readonly DatabaseContext _context;
        public ShopRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Store> getStores()
        {
            return _context.Stores.FromSqlRaw("EXEC sp_GetStores");
        }
    }
}
