namespace Structure.API.Controllers.JobControll.Request
{
    public class addJobDto
    {

        public Guid OccupationId {  get; set; }

        public string Name {  get; set; }

        public string Description { get; set; }

        public int NumberOfPosition {  get; set; }


        public List<Guid> departments { get; set; }=new List<Guid>();


    }
}
