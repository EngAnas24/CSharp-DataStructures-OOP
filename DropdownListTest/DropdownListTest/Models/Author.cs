﻿namespace DropdownListTest.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<AuthorPost> authorPosts { get; set; }


    }
}
