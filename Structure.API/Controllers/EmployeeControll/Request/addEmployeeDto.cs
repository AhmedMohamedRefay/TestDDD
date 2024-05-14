using System.ComponentModel.DataAnnotations;

namespace Structure.API.Controllers.EmployeeControll.Request
{
    public class addEmployeeDto
    {
        [Required]
        public string Name {  get; set; }

        public IFormFile Logo { get; set; }


        [Required]
        public string PasspostNumber {  get; set; }

        [Required]
        public int GenderId {  get; set; }

       [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public int NationalityId {  get; set; }

        [Required]
        public string NationalAddress {  get; set; }

        [Required]
        public string PrimaryPhoneNumber {  get; set; }

        [Required]
        public string SecondaryPhoneNumber { get; set; }

        [EmailAddress]
        public string Email {  get; set; }

        [Required]

        public Guid compnayId { get; set; }
    }
}
