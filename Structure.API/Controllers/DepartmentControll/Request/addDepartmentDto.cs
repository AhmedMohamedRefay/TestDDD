using System.ComponentModel.DataAnnotations;

namespace Structure.API.Controllers.DepartmentControll.Request
{
    public class addDepartmentDto
    {
       
        [Required]
        [Length(5,20)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$",ErrorMessage ="Name not match critieria")]
       
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public Guid? ManagerId { get; set; }

        [Required]
        public Guid companyId { get; set; }

    }
}
