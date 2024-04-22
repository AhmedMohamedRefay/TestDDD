using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test.Domain.ProductAggregation.Input;
using Test.Domain.ProductAggregation.updateProductInput;
using Test.Domain.SeedWork;
using Test.Domain.Specification;


namespace Test.Domain.ProductAggregation
{
    public class Product : BaseEntity
    {
        public Product(string name, string description, decimal price)
        {
            validate(new productInput(name, description, price));

        }
        public Product()
        {

        }

        public string Name { get; private set; }
        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public void setName(string name)
        {
            if (name == null) throw new ArgumentNullException();
            else this.Name = name;
        }


        public void setDscription(string description)
        {
            if (description == null) throw new ArgumentNullException();
            else this.Description = description;
        }

        public void setPrice(decimal price)
        {
            if (price <= 0) throw new ArgumentNullException();
            else this.Price = price;
        }

        public async Task UpdateProduct(updateProduct update)
        {
            if (update.Description == null) throw new ArgumentNullException();
            else this.Description = update.Description ;

            if (update.Name == null) throw new ArgumentNullException();
            else this.Name = update.Name;

            if (update.Price <= 0) throw new ArgumentNullException();
            else this.Price = update.Price;

        }
        private void validate(productInput input)
        {
            var x = new productSpecification().IsSatisfiedBy(this);
            if (input.name == null ||!x) throw new ArgumentNullException();
            else this.Name = input.name;

            if (input.description == null) throw new ArgumentNullException();
            else this.Description = input.description;

            if (input.price <= 0) throw new ArgumentNullException();
            else this.Price = input.price;

        }



    }
}
