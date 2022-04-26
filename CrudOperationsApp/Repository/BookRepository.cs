using CrudOperationsApp.DAL;

namespace CrudOperationsApp.Repository
{
    public class BookRepository
    {

        private readonly BookContext _context = null;
        private readonly IConfiguration _configuration;

        public BookRepository(BookContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

    }
}
