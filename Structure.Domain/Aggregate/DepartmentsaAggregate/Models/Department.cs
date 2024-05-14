using Structure.Domain.Aggregate.CompanyAggregate.Models;
using Structure.Domain.Aggregate.CompanyEmployeeInfromationAggregate.Models;
using Structure.Domain.Aggregate.DepartmentJobsAggregate.Models;
using Structure.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Structure.Domain.Aggregate.DepartmentsaAggregate.Models
{

    [Table("Department", Schema = "Structure")]
    public class Department : EntityBase
    {
        public string Name { get; private set; }

        public string? Description { get; private set; }

        public string? Logo { get; private set; }

        public string? OfficePhoneNumber { get; private set; }

        public Guid? ParentId { get; private set; }

        public Guid? ManagerId { get; private set; }
        public Guid CompanyId { get; private set; }


        public virtual CompaniesEmployeeInformations EmployeeInformations { get; private set; }
        public virtual Department department { get; private set; }

        private readonly List<DepartmentsJobs> _departmentsJobs;
        public virtual IReadOnlyCollection<DepartmentsJobs> departmentsJobs => _departmentsJobs;

        private readonly List<Department> _departments;
        public virtual IReadOnlyCollection<Department> departments => _departments;


        private readonly List<CompanyDepartmentPolicies> _companyDepartmentsPolicy;

        public Department()
        {
            _departments = new List<Department>();

            _departmentsJobs = new List<DepartmentsJobs>();
        }
        public Department(string name,string description,Guid companyId)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("name can not be null");
            if(string.IsNullOrEmpty(description)) throw new ArgumentNullException("description can not be null");
            this.Name = name;
            this.Description = description;
            this.CompanyId= companyId;
            _departments=new List<Department> ();
        }
        public Department(string name, string? description, string? logo, string? officePhoneNumber,
            Guid? parentId, Guid? managerId, Guid companyId)
        {
            Name = name;
            Description = description;
            Logo = logo;
            OfficePhoneNumber = officePhoneNumber;
            ParentId = parentId;
            ManagerId = managerId;
            CompanyId = companyId;
            _departments = new List<Department>();
        }

        public void updateDepartment(string name,string description )
        {
            this.Name= name;
            this.Description= description;
          
        }

        public virtual IReadOnlyList<CompanyDepartmentPolicies> companyDepartmentsPolicy => _companyDepartmentsPolicy;

        public void  addSubDepartment(Department department)
        {
            //department.ParentId = this.Id;
            _departments.Add(department);
        }

        public void setHigherManagerName()
        {
            this.Name = "Higher Managment";
        }

        public void setCompany(Company company)
        {
            this.CompanyId = company.Id;
        }
    }
}
