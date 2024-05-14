using System.ComponentModel.DataAnnotations;

namespace Structure.API.Controllers.EmployeeControll.Request
{
    public class resetPasswordDto
    {

        public Guid companyId {  get; set; }
        public List<Guid> Emplyees {  get; set; }

        [RegularExpression("^.*(?=.{8,})(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!#$%&?@ \"]).*$")]
        public string Password {  get; set; }


    }
}
