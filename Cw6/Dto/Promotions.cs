﻿using System.ComponentModel.DataAnnotations;

namespace Cw6.Dto
{
    public class Promotions
    {
        [Required]
        public string Studies { get; set; }

        [Required]
        public int Semester { get; set; }
    }
}
