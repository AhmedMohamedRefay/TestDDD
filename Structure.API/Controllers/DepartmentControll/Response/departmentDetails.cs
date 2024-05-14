namespace Structure.API.Controllers.DepartmentControll.Response
{
    public class departmentDetails
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public string departmentManagerName {  get; set; }

        public int NumberOfEmployees {  get; set; }

        public int NumberOfVacancy {  get; set; }

        public int NumberOfTotalJobs {  get; set; }

        public int NumberOfSubDepartment {  get; set; }

        public int Perfromance {  get; set; }

    }
}
