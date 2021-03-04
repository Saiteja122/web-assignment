using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebCoreAssignment.Models;


namespace FirstWebCoreAssignment.Pages.Admin.Author
{
   // [BindProperties(SupportsGet = true)]
    public class CreateAuthorModel : PageModel
    {

      

       [FromForm]
       public NewAuthor NewAuthor { get; set; }

    }


}
