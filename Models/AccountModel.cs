using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArtComissions.Models
{
    public class AccountModel
    {
        private string firstName;
        private string lastName;
        private string email;
        private string confirmEmail;
        private string password;
        private string confirmPassword;

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You are required to provide this information.")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You are required to provide this information.")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You are required to provide this information.")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Display(Name = "Confirm Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You are required to provide this information.")]
        [Compare("Email", ErrorMessage = "Your password and confirm password do not match.")]
        public string ConfirmEmail
        {
            get { return confirmEmail; }
            set { confirmEmail = value; }
        }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You are required to provide this information.")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Your password is not long enough.")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "You are required to provide this information.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Your password and confirm password do not match.")]
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
    }
}