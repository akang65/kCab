using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kCab.Models
{
    public class AgentAdminModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Name required")]
        [Display(Name ="Enter Name" )]
        public string Name { get; set; }

        [Required(ErrorMessage = "Last Name required")]
        [Display(Name = "Enter last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email required")]
        [Display(Name = "Enter Email")]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number required")]
        [Display(Name = "Enter Name")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Title required")]
        [Display(Name = "Enter title")]
        public string Title { get; set; }
    }
}