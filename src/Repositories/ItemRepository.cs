using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyMinimalApi.Data;
using MyMinimalApi.Models;
using System.Threading.Tasks;

namespace MyMinimalApi.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddItemsAsync(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                _context.Items.Add(item);
            }

            await _context.SaveChangesAsync();
        }



        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await _context.Items.ToListAsync(); 
        }
        public async Task AddCommentAsync(Comments comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Comments>> GetAllCommentsAsync()
        {
            return await _context.Comments.ToListAsync();
        }

      





    }

}

