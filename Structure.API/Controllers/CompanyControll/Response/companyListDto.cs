namespace Structure.API.Controllers.CompanyControll.Response
{
    public class companyListDto
    {
        public string Name { get; set; }

        public List<companyDto> companies { get; set; }

        public string CEO { get; set; }
    }
}
