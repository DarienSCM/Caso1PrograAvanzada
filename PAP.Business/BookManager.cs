using PAP.DataAccess;
using PAP.Repositories;
using System.Collections.Generic;

namespace PAP.Business
{
    public class BookManager
    {
        private readonly BookRepository _Repository;

        public BookManager()
        {
            _Repository = new BookRepository();
        }

        public IEnumerable<Books> GetAllBooksFromDataModel()
        {
            return _Repository.GetAll();
        }

        public void MigrateOldBooksToDatabase()
        {
            _Repository.SeedBooks();
        }
    }


}
