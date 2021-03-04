using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebCoreAssignment.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace FirstWebCoreAssignment.Pages.Admin.Blog
{

    public class CreateBlogModel : PageModel
    {
        [FromForm]
       
        private List<NewAuthor> NewAuthors { get; set; } = new List<NewAuthor>();
        public IEnumerable<SelectListItem> NewAuthorsList { get; private set; }

        public CreateBlogModel()
        {

            NewAuthor C1 = new NewAuthor()
            {
                FirstName = "Chetan ",
                LastName = "Bhagat",
              
            };

            NewAuthor C2 = new NewAuthor()
            {
                FirstName = "Margaret",
                LastName = "Atwood",
               
            };

           NewAuthor C3 = new NewAuthor()
            {
                FirstName = "Joanne",
                LastName = "Rowling",
              
            };

            NewAuthors.Add(C1);
            NewAuthors.Add(C2);
            NewAuthors.Add(C3);


        }

        public void OnGet()
        {

            List<SelectListItem> list = new List<SelectListItem>();
            foreach (var newauthor in NewAuthors)
            {
                list.Add(new SelectListItem(newauthor.FirstName, newauthor.LastName));
            }
            NewAuthorsList = list;

        }

        public void OnPost()
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach(var newauthor in NewAuthors)
            {
                list.Add(new SelectListItem(newauthor.FirstName, newauthor.LastName));
                if(newauthor.LastName.Equals(Request.Form.ToList()[3].Value))
                {
                    BlogPage.NewAuthor =  Convert.ToString(newauthor);

                    


                }
            }
            NewAuthorsList = list;
        }



        public Models.BlogPage BlogPage { get; set; }
        
    }
}
