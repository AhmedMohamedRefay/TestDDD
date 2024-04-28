using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.UserAggregation.Input
{
    public class UserInput
    {

        [Required]
        [MaxLength(40),MinLength(5)]
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { set; get; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { set; get; }
    }
}
