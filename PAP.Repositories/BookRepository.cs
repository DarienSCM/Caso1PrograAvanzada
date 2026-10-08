using PAP.DataAccess;


namespace PAP.Repositories
{
    public class BookRepository : RepositoryBase<Books>
    {

        public void SeedBooks()
        {
            var dataAccess = new DataAccessLayer();
            var oldBooks = dataAccess.GetAll(); // Lee los objetos de la lista anterior

            foreach (var oldBook in oldBooks)
            {
                var dbBook = new Books
                {
                    Name = oldBook.Name,
                    Title = oldBook.Title,
                    Category = oldBook.Category,
                    Publisher = oldBook.Publisher,
                    Author = oldBook.Author,
                    Description = oldBook.Description,
                    PublicationDate = oldBook.PublicationDate,
                    Height = (decimal)oldBook.Height,
                    Width = (decimal)oldBook.Width,
                    Price = oldBook.Price,
                    IsBestSeller = oldBook.IsBestSeller,
                    Genre = oldBook.Genre,
                    IsInStock = oldBook.IsInStock,
                    CreatedAt = oldBook.CreatedAt,
                    UpdatedAt = oldBook.UpdatedAt
                };

                Add(dbBook); 
            }
        }
    }
}
