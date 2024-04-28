﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Test.Application.Dto
{
    public class UserLoginDto
    {
        [Required]
        [EmailAddress]
        public string Email {  get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
