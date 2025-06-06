﻿using System.ComponentModel.DataAnnotations;

namespace ocl_msds.Helpers.Requests.Msds
{
    public class CreateMSDSRequest
    {
        [Required]
        public string? name { get; set; }

        [Required]
        public bool check { get; set; }

        [Required]
        public string? file { get; set; }

        [Required]
        public string? department { get; set; }
    }
}
