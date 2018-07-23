using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Wasalee.BindingModels
{
    public class RegisterBindingModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }
    }

    public class RegisterDriverBindingModel
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string DateOfBirth { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string HomeAddress { get; set; }

        [Required]
        public string LicenseNo { get; set; }

        public string BriefIntro { get; set; }

        public string WorkHistory { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public string Email { get; internal set; }
    }
}
