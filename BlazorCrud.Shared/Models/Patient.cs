﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Shared.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Primary Care Provider")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string PrimaryCareProvider { get; set; }
        [Required]
        [StringLength(2, ErrorMessage = "The {0} must be max {1} characters long.")]
        public string State{ get; set; }
        public List<ContactPoint> Contacts { get; set; }
    }
}