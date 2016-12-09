using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public decimal UserID { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "Please Enter Correct Email Address")]
        public string UserEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        public string UserPassword { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string UserFirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string UserLastName { get; set; }
    }
}