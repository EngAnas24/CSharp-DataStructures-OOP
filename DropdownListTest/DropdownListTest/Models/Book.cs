namespace DropdownListTest.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
     
        public virtual List<AuthorPost> authorPosts { get; set; }
    }
}
