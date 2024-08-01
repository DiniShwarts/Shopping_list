using MyMinimalApi.Models;
using System.Threading.Tasks;

namespace MyMinimalApi.Repositories
{
    public interface IItemRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task AddItemsAsync(IEnumerable<Item> items);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task AddCommentAsync(Comments comment);
        Task<IEnumerable<Comments>> GetAllCommentsAsync();
    }
}
