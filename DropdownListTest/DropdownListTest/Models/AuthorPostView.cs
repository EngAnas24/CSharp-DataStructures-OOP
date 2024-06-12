namespace DropdownListTest.Models
{
    public class AuthorPostView
    {
        public int Id { get; set; }

        public string PostCategory { get; set; }
        public string PostAuthor { get; set; }

        public IFormFile PostImageUrl { get; set; }
        public int AuthorId { get; set; }
        public Author author { get; set; }

        public int BookId { get; set; }
        public Book book { get; set; }
    }
}
