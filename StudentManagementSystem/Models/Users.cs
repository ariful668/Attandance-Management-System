
using System;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem
{
    public partial class Users
    {
        [Key]
        public long UserId { get; set; }

        [Required(ErrorMessage = "Type is mendatory.")]
        public string UserType { get; set; }

        [Required(ErrorMessage = "Password is mendatory.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "First name is mendatory.")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is mendatory.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is mendatory.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email address is not valid.")]
        public string Email { get; set; }

    }
    

}
