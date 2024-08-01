using MyMinimalApi.Models;
using MyMinimalApi.Repositories;
using System.Threading.Tasks;

namespace MyMinimalApi.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _repository.GetCategoriesAsync();
        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await _repository.GetItemsAsync();
        }

        public async Task AddItemsAsync(IEnumerable<Item> items)
        {
            await _repository.AddItemsAsync(items);
        }


        public async Task AddCommentsAsync(IEnumerable<Comments> comments)
        {
            foreach (var comment in comments)
            {
                await _repository.AddCommentAsync(comment);
            }
        }
        public async Task<IEnumerable<Comments>> GetAllCommentsAsync()
        {
            return await _repository.GetAllCommentsAsync();
        }



    }

}
