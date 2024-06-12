using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Projem.Pages
{
    public class AboutModel : PageModel
    {
        List<Book> BookArr;
        private readonly IConfiguration configuration;

        public AboutModel( IConfiguration configuration)
        {
            BookArr = new List<Book>
            {
                new Book { id = 1, name = "Anas", age = 24 },
               new Book { id = 1, name = "Abdo", age = 27 }

            };
            this.configuration = configuration;
        }

        // public string name;
        public void OnGet()
        {
            //   name = "Anas";
          
        }
        public List<Book> getdata()
        {
            return BookArr ;
        }

        public string Display()
        {
            return Properties.Resources.AboutPageTitle;
        } 
            
    }
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }


    }
}
