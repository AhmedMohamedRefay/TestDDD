using Structure.Domain.SeedWork;
using System.ComponentModel.DataAnnotations.Schema;

namespace Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Lookup
{

    [Table("Role", Schema = "Structure")]
    public class Role : EntityBase
    {
        public Role(string name)
        {
            Name = name;
        }

        public int Id { get; private set; }

        public string Name { get; set; }


    }
}