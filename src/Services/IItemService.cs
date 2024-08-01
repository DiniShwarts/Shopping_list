using MyMinimalApi.Models;
using System.Threading.Tasks;

namespace MyMinimalApi.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task AddItemsAsync(IEnumerable<Item> items);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task AddCommentsAsync(IEnumerable<Comments> comments);
        Task<IEnumerable<Comments>> GetAllCommentsAsync();

    }
}

