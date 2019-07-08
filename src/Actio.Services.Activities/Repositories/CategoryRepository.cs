using Actio.Services.Activities.Domain.Models;
using Actio.Services.Activities.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Actio.Services.Activities.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly IMongoDatabase _database;

        public CategoryRepository(IMongoDatabase database)
        {
            _database = database;
        }

        private IMongoCollection<Category> Collection => _database.GetCollection<Category>("Categories");

        public async Task AddAsync(Category category) => await Collection.InsertOneAsync(category);

        public async Task<IEnumerable<Category>> BrowseAsync() => await Collection.AsQueryable().ToListAsync();


        public async Task<Category> GetAsync(string name)
            => await Collection.AsQueryable().FirstOrDefaultAsync(x => x.Name == name.ToLowerInvariant());
        
    }
}
