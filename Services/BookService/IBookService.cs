using intership_jenkins.Entities;

namespace intership_jenkins.Services.BookService
{
    public interface IBookService
    {
        public Task<List<Book>> listAsync();
        public Task<Book> getById(string id);
        public Task createAsync(Book book);

        public Task updateAsync(string id,Book updatedBook);
        public Task removeById(string id);
    }
}
