using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FirstWebCoreAssignment.Models
{
    public class NewAuthor
    {
        [Key]
        [HiddenInput]
        [Required]
     
        public int ID { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
         [StringLength(50, MinimumLength = 1)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]
         public string FirstName { get; set; }
       
        
        [Required(ErrorMessage = "Please Enter Last Name")]
        [StringLength(50)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]
        public string LastName { get; set; }

        public string DateOfBirth { get; set; }

      
        [EmailAddress (ErrorMessage ="Invalid Entry" )]
        [Required(ErrorMessage = "Please Enter Email Address")]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

      
        [EmailAddress(ErrorMessage = "Invalid Entry")]
        [MaxLength(1500)]
        public string WebAddress { get; set; }

     
     // [Phone]
        [MaxLength(25)]
        [RegularExpression(@"\d+", ErrorMessage = "Data must be numeric")]
        public string PhoneNumber { get; set; }
     
        
        [StringLength(25)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]
        public string Country { get; set; }
       
      
       
        [StringLength(20)]
        [RegularExpression(@"^(([A-Za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Please enter upper and lower case alphabets only")]
        public string Province { get; set; }

        
      [MaxLength(20)]
        
      public string PostalCode { get; set; }

        

        // public ICollection<BlogPage> BlogPages { get; set; }


    }

    }

