using SMe.Models.Domains;

namespace SMe.Models.Interfaces
{
    public interface IShopRepository
    {
        IEnumerable<Store> getStores();
    }
}
