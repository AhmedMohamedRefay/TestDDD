using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Domain.OrderAggregation;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public class orderRepository : IOrderRepository
    {
        private readonly EcomerceDbContext _context;

        public orderRepository(EcomerceDbContext context)
        {
            _context = context;
        }

        public void Add(Order order)
        {
            _context.Add(order);
        }

        public void Delete(Order order)
        {
            _context.Remove(order);
        }

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.Include(x=>x.OrderItems).ToList();
           
        }

        public Order GetById(Guid orderId)
        {

            var ord= _context.Orders.Include(o=>o.OrderItems).Where(o=>o.Id==orderId).FirstOrDefault();

            return ord??throw new Exception("Order Not Found !");
        }

        public void Update(Order order)
        {
            _context.Update(order);
        }

     public void  savechanges()
        {
            _context.SaveChanges();

        }
    }

}