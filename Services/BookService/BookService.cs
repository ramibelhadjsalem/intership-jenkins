using intership_jenkins.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace intership_jenkins.Services.BookService
{
    public class BookService : IBookService
    {   

        private readonly IMongoCollection<Book> _booksCollection;
        public BookService(
             IOptions<DataBaseConfiguration> databaseCongif
            )
        {
            var mongoClient = new MongoClient(databaseCongif.Value.ConnectionString);
            var mongoDataBase = mongoClient.GetDatabase(databaseCongif.Value.DatabaseName);
            _booksCollection = mongoDataBase.GetCollection<Book>(typeof(Book).Name);

        }

        public async Task createAsync(Book newBook) =>
            await _booksCollection.InsertOneAsync(newBook);

       
        public async Task<Book?> getById(string id) => 
            await _booksCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<List<Book>> listAsync() => 
            await _booksCollection.Find(_ => true).ToListAsync();


        public async Task removeById(string id) => 
            await _booksCollection.DeleteOneAsync(x => x.Id == id);

        public async Task updateAsync(string id, Book updatedBook) =>
             await _booksCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        
    }   
}
